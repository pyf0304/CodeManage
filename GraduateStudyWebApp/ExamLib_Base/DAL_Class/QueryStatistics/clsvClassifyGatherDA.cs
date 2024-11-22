﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassifyGatherDA
 表名:vClassifyGather(01120015)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:51:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// v分类汇总(vClassifyGather)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvClassifyGatherDA : clsCommBase4DA
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
 return clsvClassifyGatherEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvClassifyGatherEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClassifyGatherEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvClassifyGatherEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvClassifyGatherEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vClassifyGather中,检查关键字,长度不正确!(clsvClassifyGatherDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strClassifyGatherId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vClassifyGather中,关键字不能为空 或 null!(clsvClassifyGatherDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strClassifyGatherId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvClassifyGatherDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGather where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vClassifyGather(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTable_vClassifyGather)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGather where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGather where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGather where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGather where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vClassifyGather where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClassifyGather.* from vClassifyGather Left Join {1} on {2} where {3} and vClassifyGather.ClassifyGatherId not in (Select top {5} vClassifyGather.ClassifyGatherId from vClassifyGather Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGather where {1} and ClassifyGatherId not in (Select top {2} ClassifyGatherId from vClassifyGather where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGather where {1} and ClassifyGatherId not in (Select top {3} ClassifyGatherId from vClassifyGather where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClassifyGather.* from vClassifyGather Left Join {1} on {2} where {3} and vClassifyGather.ClassifyGatherId not in (Select top {5} vClassifyGather.ClassifyGatherId from vClassifyGather Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGather where {1} and ClassifyGatherId not in (Select top {2} ClassifyGatherId from vClassifyGather where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGather where {1} and ClassifyGatherId not in (Select top {3} ClassifyGatherId from vClassifyGather where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvClassifyGatherEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvClassifyGatherDA:GetObjLst)", objException.Message));
}
List<clsvClassifyGatherEN> arrObjLst = new List<clsvClassifyGatherEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGather where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherEN objvClassifyGatherEN = new clsvClassifyGatherEN();
try
{
objvClassifyGatherEN.ClassifyGatherId = objRow[convClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherEN.ClassifyGatherName = objRow[convClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherEN.QuestionnaireSetId = objRow[convClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherEN.IsDefault = TransNullToBool(objRow[convClassifyGather.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherEN.QuestionnaireSetName = objRow[convClassifyGather.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherEN.UpdDate = objRow[convClassifyGather.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherEN.UpdUser = objRow[convClassifyGather.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherEN.Memo = objRow[convClassifyGather.Memo] == DBNull.Value ? null : objRow[convClassifyGather.Memo].ToString().Trim(); //备注
objvClassifyGatherEN.ClassifyGatherPeriod = objRow[convClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClassifyGatherDA: GetObjLst)", objException.Message));
}
objvClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClassifyGatherEN);
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
public List<clsvClassifyGatherEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvClassifyGatherDA:GetObjLstByTabName)", objException.Message));
}
List<clsvClassifyGatherEN> arrObjLst = new List<clsvClassifyGatherEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherEN objvClassifyGatherEN = new clsvClassifyGatherEN();
try
{
objvClassifyGatherEN.ClassifyGatherId = objRow[convClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherEN.ClassifyGatherName = objRow[convClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherEN.QuestionnaireSetId = objRow[convClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherEN.IsDefault = TransNullToBool(objRow[convClassifyGather.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherEN.QuestionnaireSetName = objRow[convClassifyGather.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherEN.UpdDate = objRow[convClassifyGather.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherEN.UpdUser = objRow[convClassifyGather.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherEN.Memo = objRow[convClassifyGather.Memo] == DBNull.Value ? null : objRow[convClassifyGather.Memo].ToString().Trim(); //备注
objvClassifyGatherEN.ClassifyGatherPeriod = objRow[convClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClassifyGatherDA: GetObjLst)", objException.Message));
}
objvClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClassifyGatherEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvClassifyGather(ref clsvClassifyGatherEN objvClassifyGatherEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGather where ClassifyGatherId = " + "'"+ objvClassifyGatherEN.ClassifyGatherId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvClassifyGatherEN.ClassifyGatherId = objDT.Rows[0][convClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id(字段类型:char,字段长度:4,是否可空:False)
 objvClassifyGatherEN.ClassifyGatherName = objDT.Rows[0][convClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClassifyGatherEN.QuestionnaireSetId = objDT.Rows[0][convClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objvClassifyGatherEN.IsDefault = TransNullToBool(objDT.Rows[0][convClassifyGather.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objvClassifyGatherEN.QuestionnaireSetName = objDT.Rows[0][convClassifyGather.QuestionnaireSetName].ToString().Trim(); //问卷集名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClassifyGatherEN.UpdDate = objDT.Rows[0][convClassifyGather.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherEN.UpdUser = objDT.Rows[0][convClassifyGather.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherEN.Memo = objDT.Rows[0][convClassifyGather.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvClassifyGatherEN.ClassifyGatherPeriod = objDT.Rows[0][convClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvClassifyGatherDA: GetvClassifyGather)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strClassifyGatherId">表关键字</param>
 /// <returns>表对象</returns>
public clsvClassifyGatherEN GetObjByClassifyGatherId(string strClassifyGatherId)
{
CheckPrimaryKey(strClassifyGatherId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGather where ClassifyGatherId = " + "'"+ strClassifyGatherId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvClassifyGatherEN objvClassifyGatherEN = new clsvClassifyGatherEN();
try
{
 objvClassifyGatherEN.ClassifyGatherId = objRow[convClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id(字段类型:char,字段长度:4,是否可空:False)
 objvClassifyGatherEN.ClassifyGatherName = objRow[convClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClassifyGatherEN.QuestionnaireSetId = objRow[convClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objvClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGather.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objvClassifyGatherEN.QuestionnaireSetName = objRow[convClassifyGather.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetName].ToString().Trim(); //问卷集名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClassifyGatherEN.UpdDate = objRow[convClassifyGather.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherEN.UpdUser = objRow[convClassifyGather.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherEN.Memo = objRow[convClassifyGather.Memo] == DBNull.Value ? null : objRow[convClassifyGather.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvClassifyGatherEN.ClassifyGatherPeriod = objRow[convClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvClassifyGatherDA: GetObjByClassifyGatherId)", objException.Message));
}
return objvClassifyGatherEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvClassifyGatherEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvClassifyGatherDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGather where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvClassifyGatherEN objvClassifyGatherEN = new clsvClassifyGatherEN()
{
ClassifyGatherId = objRow[convClassifyGather.ClassifyGatherId].ToString().Trim(), //分类统计Id
ClassifyGatherName = objRow[convClassifyGather.ClassifyGatherName].ToString().Trim(), //分类统计名称
QuestionnaireSetId = objRow[convClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetId].ToString().Trim(), //问卷集ID
IsDefault = TransNullToBool(objRow[convClassifyGather.IsDefault].ToString().Trim()), //是否默认
QuestionnaireSetName = objRow[convClassifyGather.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetName].ToString().Trim(), //问卷集名
UpdDate = objRow[convClassifyGather.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convClassifyGather.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convClassifyGather.Memo] == DBNull.Value ? null : objRow[convClassifyGather.Memo].ToString().Trim(), //备注
ClassifyGatherPeriod = objRow[convClassifyGather.ClassifyGatherPeriod].ToString().Trim() //分类统计时期
};
objvClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClassifyGatherEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvClassifyGatherDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvClassifyGatherEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClassifyGatherEN objvClassifyGatherEN = new clsvClassifyGatherEN();
try
{
objvClassifyGatherEN.ClassifyGatherId = objRow[convClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherEN.ClassifyGatherName = objRow[convClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherEN.QuestionnaireSetId = objRow[convClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherEN.IsDefault = TransNullToBool(objRow[convClassifyGather.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherEN.QuestionnaireSetName = objRow[convClassifyGather.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherEN.UpdDate = objRow[convClassifyGather.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherEN.UpdUser = objRow[convClassifyGather.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherEN.Memo = objRow[convClassifyGather.Memo] == DBNull.Value ? null : objRow[convClassifyGather.Memo].ToString().Trim(); //备注
objvClassifyGatherEN.ClassifyGatherPeriod = objRow[convClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvClassifyGatherDA: GetObjByDataRowvClassifyGather)", objException.Message));
}
objvClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClassifyGatherEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvClassifyGatherEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClassifyGatherEN objvClassifyGatherEN = new clsvClassifyGatherEN();
try
{
objvClassifyGatherEN.ClassifyGatherId = objRow[convClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherEN.ClassifyGatherName = objRow[convClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherEN.QuestionnaireSetId = objRow[convClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherEN.IsDefault = TransNullToBool(objRow[convClassifyGather.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherEN.QuestionnaireSetName = objRow[convClassifyGather.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGather.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherEN.UpdDate = objRow[convClassifyGather.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherEN.UpdUser = objRow[convClassifyGather.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherEN.Memo = objRow[convClassifyGather.Memo] == DBNull.Value ? null : objRow[convClassifyGather.Memo].ToString().Trim(); //备注
objvClassifyGatherEN.ClassifyGatherPeriod = objRow[convClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvClassifyGatherDA: GetObjByDataRow)", objException.Message));
}
objvClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClassifyGatherEN;
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
objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClassifyGatherEN._CurrTabName, convClassifyGather.ClassifyGatherId, 4, "");
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
objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClassifyGatherEN._CurrTabName, convClassifyGather.ClassifyGatherId, 4, strPrefix);
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
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ClassifyGatherId from vClassifyGather where " + strCondition;
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
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ClassifyGatherId from vClassifyGather where " + strCondition;
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
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClassifyGather", "ClassifyGatherId = " + "'"+ strClassifyGatherId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvClassifyGatherDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClassifyGather", strCondition))
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
objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vClassifyGather");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvClassifyGatherENS">源对象</param>
 /// <param name = "objvClassifyGatherENT">目标对象</param>
public void CopyTo(clsvClassifyGatherEN objvClassifyGatherENS, clsvClassifyGatherEN objvClassifyGatherENT)
{
objvClassifyGatherENT.ClassifyGatherId = objvClassifyGatherENS.ClassifyGatherId; //分类统计Id
objvClassifyGatherENT.ClassifyGatherName = objvClassifyGatherENS.ClassifyGatherName; //分类统计名称
objvClassifyGatherENT.QuestionnaireSetId = objvClassifyGatherENS.QuestionnaireSetId; //问卷集ID
objvClassifyGatherENT.IsDefault = objvClassifyGatherENS.IsDefault; //是否默认
objvClassifyGatherENT.QuestionnaireSetName = objvClassifyGatherENS.QuestionnaireSetName; //问卷集名
objvClassifyGatherENT.UpdDate = objvClassifyGatherENS.UpdDate; //修改日期
objvClassifyGatherENT.UpdUser = objvClassifyGatherENS.UpdUser; //修改人
objvClassifyGatherENT.Memo = objvClassifyGatherENS.Memo; //备注
objvClassifyGatherENT.ClassifyGatherPeriod = objvClassifyGatherENS.ClassifyGatherPeriod; //分类统计时期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvClassifyGatherEN objvClassifyGatherEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvClassifyGatherEN.ClassifyGatherId, 4, convClassifyGather.ClassifyGatherId);
clsCheckSql.CheckFieldLen(objvClassifyGatherEN.ClassifyGatherName, 30, convClassifyGather.ClassifyGatherName);
clsCheckSql.CheckFieldLen(objvClassifyGatherEN.QuestionnaireSetId, 4, convClassifyGather.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objvClassifyGatherEN.QuestionnaireSetName, 50, convClassifyGather.QuestionnaireSetName);
clsCheckSql.CheckFieldLen(objvClassifyGatherEN.UpdDate, 20, convClassifyGather.UpdDate);
clsCheckSql.CheckFieldLen(objvClassifyGatherEN.UpdUser, 20, convClassifyGather.UpdUser);
clsCheckSql.CheckFieldLen(objvClassifyGatherEN.Memo, 1000, convClassifyGather.Memo);
clsCheckSql.CheckFieldLen(objvClassifyGatherEN.ClassifyGatherPeriod, 50, convClassifyGather.ClassifyGatherPeriod);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherEN.ClassifyGatherId, convClassifyGather.ClassifyGatherId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherEN.ClassifyGatherName, convClassifyGather.ClassifyGatherName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherEN.QuestionnaireSetId, convClassifyGather.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherEN.QuestionnaireSetName, convClassifyGather.QuestionnaireSetName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherEN.UpdDate, convClassifyGather.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherEN.UpdUser, convClassifyGather.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherEN.Memo, convClassifyGather.Memo);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherEN.ClassifyGatherPeriod, convClassifyGather.ClassifyGatherPeriod);
//检查外键字段长度
 objvClassifyGatherEN._IsCheckProperty = true;
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
string strSQL = "select ClassifyGatherId, ClassifyGatherName from vClassifyGather ";
 clsSpecSQLforSql mySql = clsvClassifyGatherDA.GetSpecSQLObj();
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
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
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
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
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
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClassifyGatherEN._CurrTabName);
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
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClassifyGatherEN._CurrTabName, strCondition);
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
 objSQL = clsvClassifyGatherDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}