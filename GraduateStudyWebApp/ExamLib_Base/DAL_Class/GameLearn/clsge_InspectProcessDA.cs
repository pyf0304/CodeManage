
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_InspectProcessDA
 表名:ge_InspectProcess(01120910)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 检查过程表(ge_InspectProcess)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_InspectProcessDA : clsCommBase4DA
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
 return clsge_InspectProcessEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_InspectProcessEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_InspectProcessEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_InspectProcessEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_InspectProcessEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strInspectId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strInspectId)
{
strInspectId = strInspectId.Replace("'", "''");
if (strInspectId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:ge_InspectProcess中,检查关键字,长度不正确!(clsge_InspectProcessDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strInspectId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ge_InspectProcess中,关键字不能为空 或 null!(clsge_InspectProcessDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strInspectId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsge_InspectProcessDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_InspectProcess(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTable_ge_InspectProcess)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_InspectProcess where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_InspectProcess where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_InspectProcess where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_InspectProcess.* from ge_InspectProcess Left Join {1} on {2} where {3} and ge_InspectProcess.InspectId not in (Select top {5} ge_InspectProcess.InspectId from ge_InspectProcess Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_InspectProcess where {1} and InspectId not in (Select top {2} InspectId from ge_InspectProcess where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_InspectProcess where {1} and InspectId not in (Select top {3} InspectId from ge_InspectProcess where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_InspectProcess.* from ge_InspectProcess Left Join {1} on {2} where {3} and ge_InspectProcess.InspectId not in (Select top {5} ge_InspectProcess.InspectId from ge_InspectProcess Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_InspectProcess where {1} and InspectId not in (Select top {2} InspectId from ge_InspectProcess where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_InspectProcess where {1} and InspectId not in (Select top {3} InspectId from ge_InspectProcess where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_InspectProcessEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_InspectProcessDA:GetObjLst)", objException.Message));
}
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = TransNullToInt(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_InspectProcessDA: GetObjLst)", objException.Message));
}
objge_InspectProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_InspectProcessEN);
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
public List<clsge_InspectProcessEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_InspectProcessDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_InspectProcessEN> arrObjLst = new List<clsge_InspectProcessEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = TransNullToInt(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_InspectProcessDA: GetObjLst)", objException.Message));
}
objge_InspectProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_InspectProcessEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_InspectProcess(ref clsge_InspectProcessEN objge_InspectProcessEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where InspectId = " + "'"+ objge_InspectProcessEN.InspectId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_InspectProcessEN.InspectId = objDT.Rows[0][conge_InspectProcess.InspectId].ToString().Trim(); //检查Id(字段类型:char,字段长度:10,是否可空:False)
 objge_InspectProcessEN.OperationTypeId = objDT.Rows[0][conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objge_InspectProcessEN.QuestionId = TransNullToInt(objDT.Rows[0][conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_InspectProcessEN.CourseId = objDT.Rows[0][conge_InspectProcess.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_InspectProcessEN.ControlId = objDT.Rows[0][conge_InspectProcess.ControlId].ToString().Trim(); //控件Id(字段类型:varchar,字段长度:50,是否可空:True)
 objge_InspectProcessEN.ControlTypeId = objDT.Rows[0][conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id(字段类型:char,字段长度:4,是否可空:False)
 objge_InspectProcessEN.CheckMemo = objDT.Rows[0][conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述(字段类型:varchar,字段长度:100,是否可空:True)
 objge_InspectProcessEN.ControlProp = objDT.Rows[0][conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性(字段类型:varchar,字段长度:50,是否可空:True)
 objge_InspectProcessEN.AttributeId = objDT.Rows[0][conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id(字段类型:char,字段长度:4,是否可空:True)
 objge_InspectProcessEN.ControlValue = objDT.Rows[0][conge_InspectProcess.ControlValue].ToString().Trim(); //控件值(字段类型:varchar,字段长度:100,是否可空:True)
 objge_InspectProcessEN.OrderNum = TransNullToInt(objDT.Rows[0][conge_InspectProcess.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objge_InspectProcessEN.UpdUser = objDT.Rows[0][conge_InspectProcess.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_InspectProcessEN.UpdDate = objDT.Rows[0][conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_InspectProcessEN.Memo = objDT.Rows[0][conge_InspectProcess.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_InspectProcessEN.ControlClass = objDT.Rows[0][conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式(字段类型:varchar,字段长度:100,是否可空:True)
 objge_InspectProcessEN.EventTypeId = objDT.Rows[0][conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id(字段类型:char,字段长度:4,是否可空:True)
 objge_InspectProcessEN.ExaminationTypeId = objDT.Rows[0][conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id(字段类型:char,字段长度:4,是否可空:True)
 objge_InspectProcessEN.FunctionName = objDT.Rows[0][conge_InspectProcess.FunctionName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_InspectProcessDA: Getge_InspectProcess)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strInspectId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_InspectProcessEN GetObjByInspectId(string strInspectId)
{
CheckPrimaryKey(strInspectId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where InspectId = " + "'"+ strInspectId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
 objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id(字段类型:char,字段长度:10,是否可空:False)
 objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objge_InspectProcessEN.QuestionId = Int32.Parse(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id(字段类型:varchar,字段长度:50,是否可空:True)
 objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id(字段类型:char,字段长度:4,是否可空:False)
 objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述(字段类型:varchar,字段长度:100,是否可空:True)
 objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性(字段类型:varchar,字段长度:50,是否可空:True)
 objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id(字段类型:char,字段长度:4,是否可空:True)
 objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值(字段类型:varchar,字段长度:100,是否可空:True)
 objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式(字段类型:varchar,字段长度:100,是否可空:True)
 objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id(字段类型:char,字段长度:4,是否可空:True)
 objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id(字段类型:char,字段长度:4,是否可空:True)
 objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_InspectProcessDA: GetObjByInspectId)", objException.Message));
}
return objge_InspectProcessEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_InspectProcessEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN()
{
InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(), //检查Id
OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(), //操作类型ID
QuestionId = TransNullToInt(objRow[conge_InspectProcess.QuestionId].ToString().Trim()), //题目Id
CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(), //课程Id
ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(), //控件Id
ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(), //控件Id
CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(), //检查描述
ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(), //控件属性
AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(), //控件属性Id
ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(), //控件值
OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_InspectProcess.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(), //备注
ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(), //控件样式
EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(), //事件Id
ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(), //检查类型Id
FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim() //函数名
};
objge_InspectProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_InspectProcessEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_InspectProcessDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_InspectProcessEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = TransNullToInt(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_InspectProcessDA: GetObjByDataRowge_InspectProcess)", objException.Message));
}
objge_InspectProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_InspectProcessEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_InspectProcessEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_InspectProcessEN objge_InspectProcessEN = new clsge_InspectProcessEN();
try
{
objge_InspectProcessEN.InspectId = objRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objge_InspectProcessEN.OperationTypeId = objRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objge_InspectProcessEN.QuestionId = TransNullToInt(objRow[conge_InspectProcess.QuestionId].ToString().Trim()); //题目Id
objge_InspectProcessEN.CourseId = objRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objge_InspectProcessEN.ControlId = objRow[conge_InspectProcess.ControlId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objge_InspectProcessEN.ControlTypeId = objRow[conge_InspectProcess.ControlTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objge_InspectProcessEN.CheckMemo = objRow[conge_InspectProcess.CheckMemo] == DBNull.Value ? null : objRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objge_InspectProcessEN.ControlProp = objRow[conge_InspectProcess.ControlProp] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objge_InspectProcessEN.AttributeId = objRow[conge_InspectProcess.AttributeId] == DBNull.Value ? null : objRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objge_InspectProcessEN.ControlValue = objRow[conge_InspectProcess.ControlValue] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objge_InspectProcessEN.OrderNum = objRow[conge_InspectProcess.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_InspectProcess.OrderNum].ToString().Trim()); //序号
objge_InspectProcessEN.UpdUser = objRow[conge_InspectProcess.UpdUser] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objge_InspectProcessEN.UpdDate = objRow[conge_InspectProcess.UpdDate] == DBNull.Value ? null : objRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objge_InspectProcessEN.Memo = objRow[conge_InspectProcess.Memo] == DBNull.Value ? null : objRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objge_InspectProcessEN.ControlClass = objRow[conge_InspectProcess.ControlClass] == DBNull.Value ? null : objRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objge_InspectProcessEN.EventTypeId = objRow[conge_InspectProcess.EventTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objge_InspectProcessEN.ExaminationTypeId = objRow[conge_InspectProcess.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_InspectProcessEN.FunctionName = objRow[conge_InspectProcess.FunctionName] == DBNull.Value ? null : objRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_InspectProcessDA: GetObjByDataRow)", objException.Message));
}
objge_InspectProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_InspectProcessEN;
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
objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_InspectProcessEN._CurrTabName, conge_InspectProcess.InspectId, 10, "");
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
objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_InspectProcessEN._CurrTabName, conge_InspectProcess.InspectId, 10, strPrefix);
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
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select InspectId from ge_InspectProcess where " + strCondition;
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
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select InspectId from ge_InspectProcess where " + strCondition;
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
 /// <param name = "strInspectId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strInspectId)
{
CheckPrimaryKey(strInspectId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_InspectProcess", "InspectId = " + "'"+ strInspectId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_InspectProcessDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_InspectProcess", strCondition))
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
objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_InspectProcess");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_InspectProcessEN objge_InspectProcessEN)
 {
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_InspectProcessEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_InspectProcess");
objRow = objDS.Tables["ge_InspectProcess"].NewRow();
objRow[conge_InspectProcess.InspectId] = objge_InspectProcessEN.InspectId; //检查Id
objRow[conge_InspectProcess.OperationTypeId] = objge_InspectProcessEN.OperationTypeId; //操作类型ID
objRow[conge_InspectProcess.QuestionId] = objge_InspectProcessEN.QuestionId; //题目Id
objRow[conge_InspectProcess.CourseId] = objge_InspectProcessEN.CourseId; //课程Id
 if (objge_InspectProcessEN.ControlId !=  "")
 {
objRow[conge_InspectProcess.ControlId] = objge_InspectProcessEN.ControlId; //控件Id
 }
 if (objge_InspectProcessEN.ControlTypeId !=  "")
 {
objRow[conge_InspectProcess.ControlTypeId] = objge_InspectProcessEN.ControlTypeId; //控件Id
 }
 if (objge_InspectProcessEN.CheckMemo !=  "")
 {
objRow[conge_InspectProcess.CheckMemo] = objge_InspectProcessEN.CheckMemo; //检查描述
 }
 if (objge_InspectProcessEN.ControlProp !=  "")
 {
objRow[conge_InspectProcess.ControlProp] = objge_InspectProcessEN.ControlProp; //控件属性
 }
 if (objge_InspectProcessEN.AttributeId !=  "")
 {
objRow[conge_InspectProcess.AttributeId] = objge_InspectProcessEN.AttributeId; //控件属性Id
 }
 if (objge_InspectProcessEN.ControlValue !=  "")
 {
objRow[conge_InspectProcess.ControlValue] = objge_InspectProcessEN.ControlValue; //控件值
 }
objRow[conge_InspectProcess.OrderNum] = objge_InspectProcessEN.OrderNum; //序号
 if (objge_InspectProcessEN.UpdUser !=  "")
 {
objRow[conge_InspectProcess.UpdUser] = objge_InspectProcessEN.UpdUser; //修改人
 }
 if (objge_InspectProcessEN.UpdDate !=  "")
 {
objRow[conge_InspectProcess.UpdDate] = objge_InspectProcessEN.UpdDate; //修改日期
 }
 if (objge_InspectProcessEN.Memo !=  "")
 {
objRow[conge_InspectProcess.Memo] = objge_InspectProcessEN.Memo; //备注
 }
 if (objge_InspectProcessEN.ControlClass !=  "")
 {
objRow[conge_InspectProcess.ControlClass] = objge_InspectProcessEN.ControlClass; //控件样式
 }
 if (objge_InspectProcessEN.EventTypeId !=  "")
 {
objRow[conge_InspectProcess.EventTypeId] = objge_InspectProcessEN.EventTypeId; //事件Id
 }
 if (objge_InspectProcessEN.ExaminationTypeId !=  "")
 {
objRow[conge_InspectProcess.ExaminationTypeId] = objge_InspectProcessEN.ExaminationTypeId; //检查类型Id
 }
 if (objge_InspectProcessEN.FunctionName !=  "")
 {
objRow[conge_InspectProcess.FunctionName] = objge_InspectProcessEN.FunctionName; //函数名
 }
objDS.Tables[clsge_InspectProcessEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_InspectProcessEN._CurrTabName);
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_InspectProcessEN objge_InspectProcessEN)
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_InspectProcessEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_InspectProcessEN.InspectId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.InspectId);
 var strInspectId = objge_InspectProcessEN.InspectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInspectId + "'");
 }
 
 if (objge_InspectProcessEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.OperationTypeId);
 var strOperationTypeId = objge_InspectProcessEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_InspectProcess.QuestionId);
 arrValueListForInsert.Add(objge_InspectProcessEN.QuestionId.ToString());
 
 if (objge_InspectProcessEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.CourseId);
 var strCourseId = objge_InspectProcessEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_InspectProcessEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlId);
 var strControlId = objge_InspectProcessEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlId + "'");
 }
 
 if (objge_InspectProcessEN.ControlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlTypeId);
 var strControlTypeId = objge_InspectProcessEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlTypeId + "'");
 }
 
 if (objge_InspectProcessEN.CheckMemo !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.CheckMemo);
 var strCheckMemo = objge_InspectProcessEN.CheckMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckMemo + "'");
 }
 
 if (objge_InspectProcessEN.ControlProp !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlProp);
 var strControlProp = objge_InspectProcessEN.ControlProp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlProp + "'");
 }
 
 if (objge_InspectProcessEN.AttributeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.AttributeId);
 var strAttributeId = objge_InspectProcessEN.AttributeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttributeId + "'");
 }
 
 if (objge_InspectProcessEN.ControlValue !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlValue);
 var strControlValue = objge_InspectProcessEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlValue + "'");
 }
 
 if (objge_InspectProcessEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.OrderNum);
 arrValueListForInsert.Add(objge_InspectProcessEN.OrderNum.ToString());
 }
 
 if (objge_InspectProcessEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.UpdUser);
 var strUpdUser = objge_InspectProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_InspectProcessEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.UpdDate);
 var strUpdDate = objge_InspectProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_InspectProcessEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.Memo);
 var strMemo = objge_InspectProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_InspectProcessEN.ControlClass !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlClass);
 var strControlClass = objge_InspectProcessEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlClass + "'");
 }
 
 if (objge_InspectProcessEN.EventTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.EventTypeId);
 var strEventTypeId = objge_InspectProcessEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventTypeId + "'");
 }
 
 if (objge_InspectProcessEN.ExaminationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ExaminationTypeId);
 var strExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExaminationTypeId + "'");
 }
 
 if (objge_InspectProcessEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.FunctionName);
 var strFunctionName = objge_InspectProcessEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_InspectProcess");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_InspectProcessEN objge_InspectProcessEN)
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_InspectProcessEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_InspectProcessEN.InspectId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.InspectId);
 var strInspectId = objge_InspectProcessEN.InspectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInspectId + "'");
 }
 
 if (objge_InspectProcessEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.OperationTypeId);
 var strOperationTypeId = objge_InspectProcessEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_InspectProcess.QuestionId);
 arrValueListForInsert.Add(objge_InspectProcessEN.QuestionId.ToString());
 
 if (objge_InspectProcessEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.CourseId);
 var strCourseId = objge_InspectProcessEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_InspectProcessEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlId);
 var strControlId = objge_InspectProcessEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlId + "'");
 }
 
 if (objge_InspectProcessEN.ControlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlTypeId);
 var strControlTypeId = objge_InspectProcessEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlTypeId + "'");
 }
 
 if (objge_InspectProcessEN.CheckMemo !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.CheckMemo);
 var strCheckMemo = objge_InspectProcessEN.CheckMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckMemo + "'");
 }
 
 if (objge_InspectProcessEN.ControlProp !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlProp);
 var strControlProp = objge_InspectProcessEN.ControlProp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlProp + "'");
 }
 
 if (objge_InspectProcessEN.AttributeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.AttributeId);
 var strAttributeId = objge_InspectProcessEN.AttributeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttributeId + "'");
 }
 
 if (objge_InspectProcessEN.ControlValue !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlValue);
 var strControlValue = objge_InspectProcessEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlValue + "'");
 }
 
 if (objge_InspectProcessEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.OrderNum);
 arrValueListForInsert.Add(objge_InspectProcessEN.OrderNum.ToString());
 }
 
 if (objge_InspectProcessEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.UpdUser);
 var strUpdUser = objge_InspectProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_InspectProcessEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.UpdDate);
 var strUpdDate = objge_InspectProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_InspectProcessEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.Memo);
 var strMemo = objge_InspectProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_InspectProcessEN.ControlClass !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlClass);
 var strControlClass = objge_InspectProcessEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlClass + "'");
 }
 
 if (objge_InspectProcessEN.EventTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.EventTypeId);
 var strEventTypeId = objge_InspectProcessEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventTypeId + "'");
 }
 
 if (objge_InspectProcessEN.ExaminationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ExaminationTypeId);
 var strExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExaminationTypeId + "'");
 }
 
 if (objge_InspectProcessEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.FunctionName);
 var strFunctionName = objge_InspectProcessEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_InspectProcess");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objge_InspectProcessEN.InspectId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_InspectProcessEN objge_InspectProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_InspectProcessEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_InspectProcessEN.InspectId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.InspectId);
 var strInspectId = objge_InspectProcessEN.InspectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInspectId + "'");
 }
 
 if (objge_InspectProcessEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.OperationTypeId);
 var strOperationTypeId = objge_InspectProcessEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_InspectProcess.QuestionId);
 arrValueListForInsert.Add(objge_InspectProcessEN.QuestionId.ToString());
 
 if (objge_InspectProcessEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.CourseId);
 var strCourseId = objge_InspectProcessEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_InspectProcessEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlId);
 var strControlId = objge_InspectProcessEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlId + "'");
 }
 
 if (objge_InspectProcessEN.ControlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlTypeId);
 var strControlTypeId = objge_InspectProcessEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlTypeId + "'");
 }
 
 if (objge_InspectProcessEN.CheckMemo !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.CheckMemo);
 var strCheckMemo = objge_InspectProcessEN.CheckMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckMemo + "'");
 }
 
 if (objge_InspectProcessEN.ControlProp !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlProp);
 var strControlProp = objge_InspectProcessEN.ControlProp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlProp + "'");
 }
 
 if (objge_InspectProcessEN.AttributeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.AttributeId);
 var strAttributeId = objge_InspectProcessEN.AttributeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttributeId + "'");
 }
 
 if (objge_InspectProcessEN.ControlValue !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlValue);
 var strControlValue = objge_InspectProcessEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlValue + "'");
 }
 
 if (objge_InspectProcessEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.OrderNum);
 arrValueListForInsert.Add(objge_InspectProcessEN.OrderNum.ToString());
 }
 
 if (objge_InspectProcessEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.UpdUser);
 var strUpdUser = objge_InspectProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_InspectProcessEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.UpdDate);
 var strUpdDate = objge_InspectProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_InspectProcessEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.Memo);
 var strMemo = objge_InspectProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_InspectProcessEN.ControlClass !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlClass);
 var strControlClass = objge_InspectProcessEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlClass + "'");
 }
 
 if (objge_InspectProcessEN.EventTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.EventTypeId);
 var strEventTypeId = objge_InspectProcessEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventTypeId + "'");
 }
 
 if (objge_InspectProcessEN.ExaminationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ExaminationTypeId);
 var strExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExaminationTypeId + "'");
 }
 
 if (objge_InspectProcessEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.FunctionName);
 var strFunctionName = objge_InspectProcessEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_InspectProcess");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objge_InspectProcessEN.InspectId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_InspectProcessEN objge_InspectProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_InspectProcessEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_InspectProcessEN.InspectId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.InspectId);
 var strInspectId = objge_InspectProcessEN.InspectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInspectId + "'");
 }
 
 if (objge_InspectProcessEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.OperationTypeId);
 var strOperationTypeId = objge_InspectProcessEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_InspectProcess.QuestionId);
 arrValueListForInsert.Add(objge_InspectProcessEN.QuestionId.ToString());
 
 if (objge_InspectProcessEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.CourseId);
 var strCourseId = objge_InspectProcessEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_InspectProcessEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlId);
 var strControlId = objge_InspectProcessEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlId + "'");
 }
 
 if (objge_InspectProcessEN.ControlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlTypeId);
 var strControlTypeId = objge_InspectProcessEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlTypeId + "'");
 }
 
 if (objge_InspectProcessEN.CheckMemo !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.CheckMemo);
 var strCheckMemo = objge_InspectProcessEN.CheckMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckMemo + "'");
 }
 
 if (objge_InspectProcessEN.ControlProp !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlProp);
 var strControlProp = objge_InspectProcessEN.ControlProp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlProp + "'");
 }
 
 if (objge_InspectProcessEN.AttributeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.AttributeId);
 var strAttributeId = objge_InspectProcessEN.AttributeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAttributeId + "'");
 }
 
 if (objge_InspectProcessEN.ControlValue !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlValue);
 var strControlValue = objge_InspectProcessEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlValue + "'");
 }
 
 if (objge_InspectProcessEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.OrderNum);
 arrValueListForInsert.Add(objge_InspectProcessEN.OrderNum.ToString());
 }
 
 if (objge_InspectProcessEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.UpdUser);
 var strUpdUser = objge_InspectProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_InspectProcessEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.UpdDate);
 var strUpdDate = objge_InspectProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_InspectProcessEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.Memo);
 var strMemo = objge_InspectProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_InspectProcessEN.ControlClass !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ControlClass);
 var strControlClass = objge_InspectProcessEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlClass + "'");
 }
 
 if (objge_InspectProcessEN.EventTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.EventTypeId);
 var strEventTypeId = objge_InspectProcessEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventTypeId + "'");
 }
 
 if (objge_InspectProcessEN.ExaminationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.ExaminationTypeId);
 var strExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExaminationTypeId + "'");
 }
 
 if (objge_InspectProcessEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conge_InspectProcess.FunctionName);
 var strFunctionName = objge_InspectProcessEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_InspectProcess");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_InspectProcesss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where InspectId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_InspectProcess");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strInspectId = oRow[conge_InspectProcess.InspectId].ToString().Trim();
if (IsExist(strInspectId))
{
 string strResult = "关键字变量值为:" + string.Format("InspectId = {0}", strInspectId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_InspectProcessEN._CurrTabName ].NewRow();
objRow[conge_InspectProcess.InspectId] = oRow[conge_InspectProcess.InspectId].ToString().Trim(); //检查Id
objRow[conge_InspectProcess.OperationTypeId] = oRow[conge_InspectProcess.OperationTypeId].ToString().Trim(); //操作类型ID
objRow[conge_InspectProcess.QuestionId] = oRow[conge_InspectProcess.QuestionId].ToString().Trim(); //题目Id
objRow[conge_InspectProcess.CourseId] = oRow[conge_InspectProcess.CourseId].ToString().Trim(); //课程Id
objRow[conge_InspectProcess.ControlId] = oRow[conge_InspectProcess.ControlId].ToString().Trim(); //控件Id
objRow[conge_InspectProcess.ControlTypeId] = oRow[conge_InspectProcess.ControlTypeId].ToString().Trim(); //控件Id
objRow[conge_InspectProcess.CheckMemo] = oRow[conge_InspectProcess.CheckMemo].ToString().Trim(); //检查描述
objRow[conge_InspectProcess.ControlProp] = oRow[conge_InspectProcess.ControlProp].ToString().Trim(); //控件属性
objRow[conge_InspectProcess.AttributeId] = oRow[conge_InspectProcess.AttributeId].ToString().Trim(); //控件属性Id
objRow[conge_InspectProcess.ControlValue] = oRow[conge_InspectProcess.ControlValue].ToString().Trim(); //控件值
objRow[conge_InspectProcess.OrderNum] = oRow[conge_InspectProcess.OrderNum].ToString().Trim(); //序号
objRow[conge_InspectProcess.UpdUser] = oRow[conge_InspectProcess.UpdUser].ToString().Trim(); //修改人
objRow[conge_InspectProcess.UpdDate] = oRow[conge_InspectProcess.UpdDate].ToString().Trim(); //修改日期
objRow[conge_InspectProcess.Memo] = oRow[conge_InspectProcess.Memo].ToString().Trim(); //备注
objRow[conge_InspectProcess.ControlClass] = oRow[conge_InspectProcess.ControlClass].ToString().Trim(); //控件样式
objRow[conge_InspectProcess.EventTypeId] = oRow[conge_InspectProcess.EventTypeId].ToString().Trim(); //事件Id
objRow[conge_InspectProcess.ExaminationTypeId] = oRow[conge_InspectProcess.ExaminationTypeId].ToString().Trim(); //检查类型Id
objRow[conge_InspectProcess.FunctionName] = oRow[conge_InspectProcess.FunctionName].ToString().Trim(); //函数名
 objDS.Tables[clsge_InspectProcessEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_InspectProcessEN._CurrTabName);
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
 /// <param name = "objge_InspectProcessEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_InspectProcessEN objge_InspectProcessEN)
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_InspectProcessEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
strSQL = "Select * from ge_InspectProcess where InspectId = " + "'"+ objge_InspectProcessEN.InspectId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_InspectProcessEN._CurrTabName);
if (objDS.Tables[clsge_InspectProcessEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:InspectId = " + "'"+ objge_InspectProcessEN.InspectId+"'");
return false;
}
objRow = objDS.Tables[clsge_InspectProcessEN._CurrTabName].Rows[0];
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.InspectId))
 {
objRow[conge_InspectProcess.InspectId] = objge_InspectProcessEN.InspectId; //检查Id
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OperationTypeId))
 {
objRow[conge_InspectProcess.OperationTypeId] = objge_InspectProcessEN.OperationTypeId; //操作类型ID
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.QuestionId))
 {
objRow[conge_InspectProcess.QuestionId] = objge_InspectProcessEN.QuestionId; //题目Id
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CourseId))
 {
objRow[conge_InspectProcess.CourseId] = objge_InspectProcessEN.CourseId; //课程Id
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlId))
 {
objRow[conge_InspectProcess.ControlId] = objge_InspectProcessEN.ControlId; //控件Id
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlTypeId))
 {
objRow[conge_InspectProcess.ControlTypeId] = objge_InspectProcessEN.ControlTypeId; //控件Id
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CheckMemo))
 {
objRow[conge_InspectProcess.CheckMemo] = objge_InspectProcessEN.CheckMemo; //检查描述
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlProp))
 {
objRow[conge_InspectProcess.ControlProp] = objge_InspectProcessEN.ControlProp; //控件属性
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.AttributeId))
 {
objRow[conge_InspectProcess.AttributeId] = objge_InspectProcessEN.AttributeId; //控件属性Id
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlValue))
 {
objRow[conge_InspectProcess.ControlValue] = objge_InspectProcessEN.ControlValue; //控件值
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OrderNum))
 {
objRow[conge_InspectProcess.OrderNum] = objge_InspectProcessEN.OrderNum; //序号
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdUser))
 {
objRow[conge_InspectProcess.UpdUser] = objge_InspectProcessEN.UpdUser; //修改人
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdDate))
 {
objRow[conge_InspectProcess.UpdDate] = objge_InspectProcessEN.UpdDate; //修改日期
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.Memo))
 {
objRow[conge_InspectProcess.Memo] = objge_InspectProcessEN.Memo; //备注
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlClass))
 {
objRow[conge_InspectProcess.ControlClass] = objge_InspectProcessEN.ControlClass; //控件样式
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.EventTypeId))
 {
objRow[conge_InspectProcess.EventTypeId] = objge_InspectProcessEN.EventTypeId; //事件Id
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ExaminationTypeId))
 {
objRow[conge_InspectProcess.ExaminationTypeId] = objge_InspectProcessEN.ExaminationTypeId; //检查类型Id
 }
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.FunctionName))
 {
objRow[conge_InspectProcess.FunctionName] = objge_InspectProcessEN.FunctionName; //函数名
 }
try
{
objDA.Update(objDS, clsge_InspectProcessEN._CurrTabName);
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_InspectProcessEN objge_InspectProcessEN)
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_InspectProcessEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_InspectProcess Set ");
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OperationTypeId))
 {
 if (objge_InspectProcessEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objge_InspectProcessEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conge_InspectProcess.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.OperationTypeId); //操作类型ID
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_InspectProcessEN.QuestionId, conge_InspectProcess.QuestionId); //题目Id
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CourseId))
 {
 if (objge_InspectProcessEN.CourseId !=  null)
 {
 var strCourseId = objge_InspectProcessEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_InspectProcess.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.CourseId); //课程Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlId))
 {
 if (objge_InspectProcessEN.ControlId !=  null)
 {
 var strControlId = objge_InspectProcessEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlId, conge_InspectProcess.ControlId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlId); //控件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlTypeId))
 {
 if (objge_InspectProcessEN.ControlTypeId !=  null)
 {
 var strControlTypeId = objge_InspectProcessEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlTypeId, conge_InspectProcess.ControlTypeId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlTypeId); //控件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CheckMemo))
 {
 if (objge_InspectProcessEN.CheckMemo !=  null)
 {
 var strCheckMemo = objge_InspectProcessEN.CheckMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckMemo, conge_InspectProcess.CheckMemo); //检查描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.CheckMemo); //检查描述
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlProp))
 {
 if (objge_InspectProcessEN.ControlProp !=  null)
 {
 var strControlProp = objge_InspectProcessEN.ControlProp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlProp, conge_InspectProcess.ControlProp); //控件属性
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlProp); //控件属性
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.AttributeId))
 {
 if (objge_InspectProcessEN.AttributeId !=  null)
 {
 var strAttributeId = objge_InspectProcessEN.AttributeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAttributeId, conge_InspectProcess.AttributeId); //控件属性Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.AttributeId); //控件属性Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlValue))
 {
 if (objge_InspectProcessEN.ControlValue !=  null)
 {
 var strControlValue = objge_InspectProcessEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlValue, conge_InspectProcess.ControlValue); //控件值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlValue); //控件值
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OrderNum))
 {
 if (objge_InspectProcessEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_InspectProcessEN.OrderNum, conge_InspectProcess.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.OrderNum); //序号
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdUser))
 {
 if (objge_InspectProcessEN.UpdUser !=  null)
 {
 var strUpdUser = objge_InspectProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_InspectProcess.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.UpdUser); //修改人
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdDate))
 {
 if (objge_InspectProcessEN.UpdDate !=  null)
 {
 var strUpdDate = objge_InspectProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_InspectProcess.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.UpdDate); //修改日期
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.Memo))
 {
 if (objge_InspectProcessEN.Memo !=  null)
 {
 var strMemo = objge_InspectProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_InspectProcess.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.Memo); //备注
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlClass))
 {
 if (objge_InspectProcessEN.ControlClass !=  null)
 {
 var strControlClass = objge_InspectProcessEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlClass, conge_InspectProcess.ControlClass); //控件样式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlClass); //控件样式
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.EventTypeId))
 {
 if (objge_InspectProcessEN.EventTypeId !=  null)
 {
 var strEventTypeId = objge_InspectProcessEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEventTypeId, conge_InspectProcess.EventTypeId); //事件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.EventTypeId); //事件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ExaminationTypeId))
 {
 if (objge_InspectProcessEN.ExaminationTypeId !=  null)
 {
 var strExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExaminationTypeId, conge_InspectProcess.ExaminationTypeId); //检查类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ExaminationTypeId); //检查类型Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.FunctionName))
 {
 if (objge_InspectProcessEN.FunctionName !=  null)
 {
 var strFunctionName = objge_InspectProcessEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conge_InspectProcess.FunctionName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.FunctionName); //函数名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where InspectId = '{0}'", objge_InspectProcessEN.InspectId); 
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
 /// <param name = "objge_InspectProcessEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_InspectProcessEN objge_InspectProcessEN, string strCondition)
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_InspectProcessEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_InspectProcess Set ");
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OperationTypeId))
 {
 if (objge_InspectProcessEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objge_InspectProcessEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_InspectProcessEN.QuestionId); //题目Id
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CourseId))
 {
 if (objge_InspectProcessEN.CourseId !=  null)
 {
 var strCourseId = objge_InspectProcessEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlId))
 {
 if (objge_InspectProcessEN.ControlId !=  null)
 {
 var strControlId = objge_InspectProcessEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlId = '{0}',", strControlId); //控件Id
 }
 else
 {
 sbSQL.Append(" ControlId = null,"); //控件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlTypeId))
 {
 if (objge_InspectProcessEN.ControlTypeId !=  null)
 {
 var strControlTypeId = objge_InspectProcessEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlTypeId = '{0}',", strControlTypeId); //控件Id
 }
 else
 {
 sbSQL.Append(" ControlTypeId = null,"); //控件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CheckMemo))
 {
 if (objge_InspectProcessEN.CheckMemo !=  null)
 {
 var strCheckMemo = objge_InspectProcessEN.CheckMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckMemo = '{0}',", strCheckMemo); //检查描述
 }
 else
 {
 sbSQL.Append(" CheckMemo = null,"); //检查描述
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlProp))
 {
 if (objge_InspectProcessEN.ControlProp !=  null)
 {
 var strControlProp = objge_InspectProcessEN.ControlProp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlProp = '{0}',", strControlProp); //控件属性
 }
 else
 {
 sbSQL.Append(" ControlProp = null,"); //控件属性
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.AttributeId))
 {
 if (objge_InspectProcessEN.AttributeId !=  null)
 {
 var strAttributeId = objge_InspectProcessEN.AttributeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AttributeId = '{0}',", strAttributeId); //控件属性Id
 }
 else
 {
 sbSQL.Append(" AttributeId = null,"); //控件属性Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlValue))
 {
 if (objge_InspectProcessEN.ControlValue !=  null)
 {
 var strControlValue = objge_InspectProcessEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlValue = '{0}',", strControlValue); //控件值
 }
 else
 {
 sbSQL.Append(" ControlValue = null,"); //控件值
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OrderNum))
 {
 if (objge_InspectProcessEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_InspectProcessEN.OrderNum, conge_InspectProcess.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.OrderNum); //序号
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdUser))
 {
 if (objge_InspectProcessEN.UpdUser !=  null)
 {
 var strUpdUser = objge_InspectProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdDate))
 {
 if (objge_InspectProcessEN.UpdDate !=  null)
 {
 var strUpdDate = objge_InspectProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.Memo))
 {
 if (objge_InspectProcessEN.Memo !=  null)
 {
 var strMemo = objge_InspectProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlClass))
 {
 if (objge_InspectProcessEN.ControlClass !=  null)
 {
 var strControlClass = objge_InspectProcessEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlClass = '{0}',", strControlClass); //控件样式
 }
 else
 {
 sbSQL.Append(" ControlClass = null,"); //控件样式
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.EventTypeId))
 {
 if (objge_InspectProcessEN.EventTypeId !=  null)
 {
 var strEventTypeId = objge_InspectProcessEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EventTypeId = '{0}',", strEventTypeId); //事件Id
 }
 else
 {
 sbSQL.Append(" EventTypeId = null,"); //事件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ExaminationTypeId))
 {
 if (objge_InspectProcessEN.ExaminationTypeId !=  null)
 {
 var strExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExaminationTypeId = '{0}',", strExaminationTypeId); //检查类型Id
 }
 else
 {
 sbSQL.Append(" ExaminationTypeId = null,"); //检查类型Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.FunctionName))
 {
 if (objge_InspectProcessEN.FunctionName !=  null)
 {
 var strFunctionName = objge_InspectProcessEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //函数名
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //函数名
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
 /// <param name = "objge_InspectProcessEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_InspectProcessEN objge_InspectProcessEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_InspectProcessEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_InspectProcess Set ");
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OperationTypeId))
 {
 if (objge_InspectProcessEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objge_InspectProcessEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_InspectProcessEN.QuestionId); //题目Id
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CourseId))
 {
 if (objge_InspectProcessEN.CourseId !=  null)
 {
 var strCourseId = objge_InspectProcessEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlId))
 {
 if (objge_InspectProcessEN.ControlId !=  null)
 {
 var strControlId = objge_InspectProcessEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlId = '{0}',", strControlId); //控件Id
 }
 else
 {
 sbSQL.Append(" ControlId = null,"); //控件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlTypeId))
 {
 if (objge_InspectProcessEN.ControlTypeId !=  null)
 {
 var strControlTypeId = objge_InspectProcessEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlTypeId = '{0}',", strControlTypeId); //控件Id
 }
 else
 {
 sbSQL.Append(" ControlTypeId = null,"); //控件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CheckMemo))
 {
 if (objge_InspectProcessEN.CheckMemo !=  null)
 {
 var strCheckMemo = objge_InspectProcessEN.CheckMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckMemo = '{0}',", strCheckMemo); //检查描述
 }
 else
 {
 sbSQL.Append(" CheckMemo = null,"); //检查描述
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlProp))
 {
 if (objge_InspectProcessEN.ControlProp !=  null)
 {
 var strControlProp = objge_InspectProcessEN.ControlProp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlProp = '{0}',", strControlProp); //控件属性
 }
 else
 {
 sbSQL.Append(" ControlProp = null,"); //控件属性
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.AttributeId))
 {
 if (objge_InspectProcessEN.AttributeId !=  null)
 {
 var strAttributeId = objge_InspectProcessEN.AttributeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AttributeId = '{0}',", strAttributeId); //控件属性Id
 }
 else
 {
 sbSQL.Append(" AttributeId = null,"); //控件属性Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlValue))
 {
 if (objge_InspectProcessEN.ControlValue !=  null)
 {
 var strControlValue = objge_InspectProcessEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlValue = '{0}',", strControlValue); //控件值
 }
 else
 {
 sbSQL.Append(" ControlValue = null,"); //控件值
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OrderNum))
 {
 if (objge_InspectProcessEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_InspectProcessEN.OrderNum, conge_InspectProcess.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.OrderNum); //序号
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdUser))
 {
 if (objge_InspectProcessEN.UpdUser !=  null)
 {
 var strUpdUser = objge_InspectProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdDate))
 {
 if (objge_InspectProcessEN.UpdDate !=  null)
 {
 var strUpdDate = objge_InspectProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.Memo))
 {
 if (objge_InspectProcessEN.Memo !=  null)
 {
 var strMemo = objge_InspectProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlClass))
 {
 if (objge_InspectProcessEN.ControlClass !=  null)
 {
 var strControlClass = objge_InspectProcessEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlClass = '{0}',", strControlClass); //控件样式
 }
 else
 {
 sbSQL.Append(" ControlClass = null,"); //控件样式
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.EventTypeId))
 {
 if (objge_InspectProcessEN.EventTypeId !=  null)
 {
 var strEventTypeId = objge_InspectProcessEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EventTypeId = '{0}',", strEventTypeId); //事件Id
 }
 else
 {
 sbSQL.Append(" EventTypeId = null,"); //事件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ExaminationTypeId))
 {
 if (objge_InspectProcessEN.ExaminationTypeId !=  null)
 {
 var strExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExaminationTypeId = '{0}',", strExaminationTypeId); //检查类型Id
 }
 else
 {
 sbSQL.Append(" ExaminationTypeId = null,"); //检查类型Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.FunctionName))
 {
 if (objge_InspectProcessEN.FunctionName !=  null)
 {
 var strFunctionName = objge_InspectProcessEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //函数名
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //函数名
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
 /// <param name = "objge_InspectProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_InspectProcessEN objge_InspectProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_InspectProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_InspectProcessEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_InspectProcess Set ");
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OperationTypeId))
 {
 if (objge_InspectProcessEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objge_InspectProcessEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conge_InspectProcess.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.OperationTypeId); //操作类型ID
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_InspectProcessEN.QuestionId, conge_InspectProcess.QuestionId); //题目Id
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CourseId))
 {
 if (objge_InspectProcessEN.CourseId !=  null)
 {
 var strCourseId = objge_InspectProcessEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_InspectProcess.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.CourseId); //课程Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlId))
 {
 if (objge_InspectProcessEN.ControlId !=  null)
 {
 var strControlId = objge_InspectProcessEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlId, conge_InspectProcess.ControlId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlId); //控件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlTypeId))
 {
 if (objge_InspectProcessEN.ControlTypeId !=  null)
 {
 var strControlTypeId = objge_InspectProcessEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlTypeId, conge_InspectProcess.ControlTypeId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlTypeId); //控件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.CheckMemo))
 {
 if (objge_InspectProcessEN.CheckMemo !=  null)
 {
 var strCheckMemo = objge_InspectProcessEN.CheckMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckMemo, conge_InspectProcess.CheckMemo); //检查描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.CheckMemo); //检查描述
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlProp))
 {
 if (objge_InspectProcessEN.ControlProp !=  null)
 {
 var strControlProp = objge_InspectProcessEN.ControlProp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlProp, conge_InspectProcess.ControlProp); //控件属性
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlProp); //控件属性
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.AttributeId))
 {
 if (objge_InspectProcessEN.AttributeId !=  null)
 {
 var strAttributeId = objge_InspectProcessEN.AttributeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAttributeId, conge_InspectProcess.AttributeId); //控件属性Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.AttributeId); //控件属性Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlValue))
 {
 if (objge_InspectProcessEN.ControlValue !=  null)
 {
 var strControlValue = objge_InspectProcessEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlValue, conge_InspectProcess.ControlValue); //控件值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlValue); //控件值
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.OrderNum))
 {
 if (objge_InspectProcessEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_InspectProcessEN.OrderNum, conge_InspectProcess.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.OrderNum); //序号
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdUser))
 {
 if (objge_InspectProcessEN.UpdUser !=  null)
 {
 var strUpdUser = objge_InspectProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_InspectProcess.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.UpdUser); //修改人
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.UpdDate))
 {
 if (objge_InspectProcessEN.UpdDate !=  null)
 {
 var strUpdDate = objge_InspectProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_InspectProcess.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.UpdDate); //修改日期
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.Memo))
 {
 if (objge_InspectProcessEN.Memo !=  null)
 {
 var strMemo = objge_InspectProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_InspectProcess.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.Memo); //备注
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ControlClass))
 {
 if (objge_InspectProcessEN.ControlClass !=  null)
 {
 var strControlClass = objge_InspectProcessEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlClass, conge_InspectProcess.ControlClass); //控件样式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ControlClass); //控件样式
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.EventTypeId))
 {
 if (objge_InspectProcessEN.EventTypeId !=  null)
 {
 var strEventTypeId = objge_InspectProcessEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEventTypeId, conge_InspectProcess.EventTypeId); //事件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.EventTypeId); //事件Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.ExaminationTypeId))
 {
 if (objge_InspectProcessEN.ExaminationTypeId !=  null)
 {
 var strExaminationTypeId = objge_InspectProcessEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExaminationTypeId, conge_InspectProcess.ExaminationTypeId); //检查类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.ExaminationTypeId); //检查类型Id
 }
 }
 
 if (objge_InspectProcessEN.IsUpdated(conge_InspectProcess.FunctionName))
 {
 if (objge_InspectProcessEN.FunctionName !=  null)
 {
 var strFunctionName = objge_InspectProcessEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conge_InspectProcess.FunctionName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_InspectProcess.FunctionName); //函数名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where InspectId = '{0}'", objge_InspectProcessEN.InspectId); 
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
 /// <param name = "strInspectId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strInspectId) 
{
CheckPrimaryKey(strInspectId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strInspectId,
};
 objSQL.ExecSP("ge_InspectProcess_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strInspectId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strInspectId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strInspectId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
//删除ge_InspectProcess本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_InspectProcess where InspectId = " + "'"+ strInspectId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_InspectProcess(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
//删除ge_InspectProcess本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_InspectProcess where InspectId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strInspectId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strInspectId) 
{
CheckPrimaryKey(strInspectId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
//删除ge_InspectProcess本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_InspectProcess where InspectId = " + "'"+ strInspectId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_InspectProcess(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: Delge_InspectProcess)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_InspectProcess where " + strCondition ;
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
public bool Delge_InspectProcessWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_InspectProcessDA: Delge_InspectProcessWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_InspectProcess where " + strCondition ;
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
 /// <param name = "objge_InspectProcessENS">源对象</param>
 /// <param name = "objge_InspectProcessENT">目标对象</param>
public void CopyTo(clsge_InspectProcessEN objge_InspectProcessENS, clsge_InspectProcessEN objge_InspectProcessENT)
{
objge_InspectProcessENT.InspectId = objge_InspectProcessENS.InspectId; //检查Id
objge_InspectProcessENT.OperationTypeId = objge_InspectProcessENS.OperationTypeId; //操作类型ID
objge_InspectProcessENT.QuestionId = objge_InspectProcessENS.QuestionId; //题目Id
objge_InspectProcessENT.CourseId = objge_InspectProcessENS.CourseId; //课程Id
objge_InspectProcessENT.ControlId = objge_InspectProcessENS.ControlId; //控件Id
objge_InspectProcessENT.ControlTypeId = objge_InspectProcessENS.ControlTypeId; //控件Id
objge_InspectProcessENT.CheckMemo = objge_InspectProcessENS.CheckMemo; //检查描述
objge_InspectProcessENT.ControlProp = objge_InspectProcessENS.ControlProp; //控件属性
objge_InspectProcessENT.AttributeId = objge_InspectProcessENS.AttributeId; //控件属性Id
objge_InspectProcessENT.ControlValue = objge_InspectProcessENS.ControlValue; //控件值
objge_InspectProcessENT.OrderNum = objge_InspectProcessENS.OrderNum; //序号
objge_InspectProcessENT.UpdUser = objge_InspectProcessENS.UpdUser; //修改人
objge_InspectProcessENT.UpdDate = objge_InspectProcessENS.UpdDate; //修改日期
objge_InspectProcessENT.Memo = objge_InspectProcessENS.Memo; //备注
objge_InspectProcessENT.ControlClass = objge_InspectProcessENS.ControlClass; //控件样式
objge_InspectProcessENT.EventTypeId = objge_InspectProcessENS.EventTypeId; //事件Id
objge_InspectProcessENT.ExaminationTypeId = objge_InspectProcessENS.ExaminationTypeId; //检查类型Id
objge_InspectProcessENT.FunctionName = objge_InspectProcessENS.FunctionName; //函数名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_InspectProcessEN objge_InspectProcessEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_InspectProcessEN.OperationTypeId, conge_InspectProcess.OperationTypeId);
clsCheckSql.CheckFieldNotNull(objge_InspectProcessEN.QuestionId, conge_InspectProcess.QuestionId);
clsCheckSql.CheckFieldNotNull(objge_InspectProcessEN.CourseId, conge_InspectProcess.CourseId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.InspectId, 10, conge_InspectProcess.InspectId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.OperationTypeId, 4, conge_InspectProcess.OperationTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.CourseId, 8, conge_InspectProcess.CourseId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlId, 50, conge_InspectProcess.ControlId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlTypeId, 4, conge_InspectProcess.ControlTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.CheckMemo, 100, conge_InspectProcess.CheckMemo);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlProp, 50, conge_InspectProcess.ControlProp);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.AttributeId, 4, conge_InspectProcess.AttributeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlValue, 100, conge_InspectProcess.ControlValue);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.UpdUser, 20, conge_InspectProcess.UpdUser);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.UpdDate, 20, conge_InspectProcess.UpdDate);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.Memo, 1000, conge_InspectProcess.Memo);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlClass, 100, conge_InspectProcess.ControlClass);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.EventTypeId, 4, conge_InspectProcess.EventTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ExaminationTypeId, 4, conge_InspectProcess.ExaminationTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.FunctionName, 100, conge_InspectProcess.FunctionName);
//检查字段外键固定长度
 objge_InspectProcessEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_InspectProcessEN objge_InspectProcessEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.OperationTypeId, 4, conge_InspectProcess.OperationTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.CourseId, 8, conge_InspectProcess.CourseId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlId, 50, conge_InspectProcess.ControlId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlTypeId, 4, conge_InspectProcess.ControlTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.CheckMemo, 100, conge_InspectProcess.CheckMemo);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlProp, 50, conge_InspectProcess.ControlProp);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.AttributeId, 4, conge_InspectProcess.AttributeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlValue, 100, conge_InspectProcess.ControlValue);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.UpdUser, 20, conge_InspectProcess.UpdUser);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.UpdDate, 20, conge_InspectProcess.UpdDate);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.Memo, 1000, conge_InspectProcess.Memo);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlClass, 100, conge_InspectProcess.ControlClass);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.EventTypeId, 4, conge_InspectProcess.EventTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ExaminationTypeId, 4, conge_InspectProcess.ExaminationTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.FunctionName, 100, conge_InspectProcess.FunctionName);
//检查外键字段长度
 objge_InspectProcessEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_InspectProcessEN objge_InspectProcessEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.InspectId, 10, conge_InspectProcess.InspectId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.OperationTypeId, 4, conge_InspectProcess.OperationTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.CourseId, 8, conge_InspectProcess.CourseId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlId, 50, conge_InspectProcess.ControlId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlTypeId, 4, conge_InspectProcess.ControlTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.CheckMemo, 100, conge_InspectProcess.CheckMemo);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlProp, 50, conge_InspectProcess.ControlProp);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.AttributeId, 4, conge_InspectProcess.AttributeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlValue, 100, conge_InspectProcess.ControlValue);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.UpdUser, 20, conge_InspectProcess.UpdUser);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.UpdDate, 20, conge_InspectProcess.UpdDate);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.Memo, 1000, conge_InspectProcess.Memo);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ControlClass, 100, conge_InspectProcess.ControlClass);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.EventTypeId, 4, conge_InspectProcess.EventTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.ExaminationTypeId, 4, conge_InspectProcess.ExaminationTypeId);
clsCheckSql.CheckFieldLen(objge_InspectProcessEN.FunctionName, 100, conge_InspectProcess.FunctionName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.InspectId, conge_InspectProcess.InspectId);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.OperationTypeId, conge_InspectProcess.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.CourseId, conge_InspectProcess.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.ControlId, conge_InspectProcess.ControlId);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.ControlTypeId, conge_InspectProcess.ControlTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.CheckMemo, conge_InspectProcess.CheckMemo);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.ControlProp, conge_InspectProcess.ControlProp);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.AttributeId, conge_InspectProcess.AttributeId);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.ControlValue, conge_InspectProcess.ControlValue);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.UpdUser, conge_InspectProcess.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.UpdDate, conge_InspectProcess.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.Memo, conge_InspectProcess.Memo);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.ControlClass, conge_InspectProcess.ControlClass);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.EventTypeId, conge_InspectProcess.EventTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.ExaminationTypeId, conge_InspectProcess.ExaminationTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_InspectProcessEN.FunctionName, conge_InspectProcess.FunctionName);
//检查外键字段长度
 objge_InspectProcessEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetInspectId()
{
//获取某学院所有专业信息
string strSQL = "select InspectId, OperationTypeId from ge_InspectProcess ";
 clsSpecSQLforSql mySql = clsge_InspectProcessDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_InspectProcess(检查过程表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_InspectProcessEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_InspectProcessEN objge_InspectProcessEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InspectId = '{0}'", objge_InspectProcessEN.InspectId);
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
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_InspectProcessEN._CurrTabName);
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
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_InspectProcessEN._CurrTabName, strCondition);
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
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
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
 objSQL = clsge_InspectProcessDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}