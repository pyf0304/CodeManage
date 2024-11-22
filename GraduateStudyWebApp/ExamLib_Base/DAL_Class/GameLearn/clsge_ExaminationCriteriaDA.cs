
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ExaminationCriteriaDA
 表名:ge_ExaminationCriteria(01120898)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:03
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
 /// 题目检查标准表(ge_ExaminationCriteria)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_ExaminationCriteriaDA : clsCommBase4DA
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
 return clsge_ExaminationCriteriaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_ExaminationCriteriaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_ExaminationCriteriaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_ExaminationCriteriaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_ExaminationCriteriaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCriteriaId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCriteriaId)
{
strCriteriaId = strCriteriaId.Replace("'", "''");
if (strCriteriaId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:ge_ExaminationCriteria中,检查关键字,长度不正确!(clsge_ExaminationCriteriaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCriteriaId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ge_ExaminationCriteria中,关键字不能为空 或 null!(clsge_ExaminationCriteriaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCriteriaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsge_ExaminationCriteriaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_ExaminationCriteria(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTable_ge_ExaminationCriteria)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_ExaminationCriteria where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_ExaminationCriteria where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_ExaminationCriteria where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_ExaminationCriteria.* from ge_ExaminationCriteria Left Join {1} on {2} where {3} and ge_ExaminationCriteria.CriteriaId not in (Select top {5} ge_ExaminationCriteria.CriteriaId from ge_ExaminationCriteria Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_ExaminationCriteria where {1} and CriteriaId not in (Select top {2} CriteriaId from ge_ExaminationCriteria where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_ExaminationCriteria where {1} and CriteriaId not in (Select top {3} CriteriaId from ge_ExaminationCriteria where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_ExaminationCriteria.* from ge_ExaminationCriteria Left Join {1} on {2} where {3} and ge_ExaminationCriteria.CriteriaId not in (Select top {5} ge_ExaminationCriteria.CriteriaId from ge_ExaminationCriteria Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_ExaminationCriteria where {1} and CriteriaId not in (Select top {2} CriteriaId from ge_ExaminationCriteria where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_ExaminationCriteria where {1} and CriteriaId not in (Select top {3} CriteriaId from ge_ExaminationCriteria where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_ExaminationCriteriaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA:GetObjLst)", objException.Message));
}
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = TransNullToInt(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_ExaminationCriteriaDA: GetObjLst)", objException.Message));
}
objge_ExaminationCriteriaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_ExaminationCriteriaEN);
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
public List<clsge_ExaminationCriteriaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_ExaminationCriteriaEN> arrObjLst = new List<clsge_ExaminationCriteriaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = TransNullToInt(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_ExaminationCriteriaDA: GetObjLst)", objException.Message));
}
objge_ExaminationCriteriaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_ExaminationCriteriaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_ExaminationCriteria(ref clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where CriteriaId = " + "'"+ objge_ExaminationCriteriaEN.CriteriaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_ExaminationCriteriaEN.CriteriaId = objDT.Rows[0][conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id(字段类型:char,字段长度:10,是否可空:True)
 objge_ExaminationCriteriaEN.QuestionId = TransNullToInt(objDT.Rows[0][conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_ExaminationCriteriaEN.CourseId = objDT.Rows[0][conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_ExaminationCriteriaEN.Describe = objDT.Rows[0][conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_ExaminationCriteriaEN.ControlTypeId = objDT.Rows[0][conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id(字段类型:char,字段长度:4,是否可空:False)
 objge_ExaminationCriteriaEN.EventTypeId = objDT.Rows[0][conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id(字段类型:char,字段长度:4,是否可空:True)
 objge_ExaminationCriteriaEN.ExaminationTypeId = objDT.Rows[0][conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id(字段类型:char,字段长度:4,是否可空:True)
 objge_ExaminationCriteriaEN.ControlId = objDT.Rows[0][conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id(字段类型:varchar,字段长度:50,是否可空:True)
 objge_ExaminationCriteriaEN.ControlClass = objDT.Rows[0][conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ExaminationCriteriaEN.ControlValue = objDT.Rows[0][conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ExaminationCriteriaEN.ControlHtml = objDT.Rows[0][conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ExaminationCriteriaEN.UpdDate = objDT.Rows[0][conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ExaminationCriteriaEN.UpdUser = objDT.Rows[0][conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ExaminationCriteriaEN.Memo = objDT.Rows[0][conge_ExaminationCriteria.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_ExaminationCriteriaEN.OrderNum = TransNullToInt(objDT.Rows[0][conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_ExaminationCriteriaDA: Getge_ExaminationCriteria)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCriteriaId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_ExaminationCriteriaEN GetObjByCriteriaId(string strCriteriaId)
{
CheckPrimaryKey(strCriteriaId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where CriteriaId = " + "'"+ strCriteriaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
 objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id(字段类型:char,字段长度:10,是否可空:True)
 objge_ExaminationCriteriaEN.QuestionId = Int32.Parse(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id(字段类型:char,字段长度:4,是否可空:False)
 objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id(字段类型:char,字段长度:4,是否可空:True)
 objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id(字段类型:char,字段长度:4,是否可空:True)
 objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id(字段类型:varchar,字段长度:50,是否可空:True)
 objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html(字段类型:varchar,字段长度:100,是否可空:True)
 objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_ExaminationCriteriaDA: GetObjByCriteriaId)", objException.Message));
}
return objge_ExaminationCriteriaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_ExaminationCriteriaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN()
{
CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(), //标准Id
QuestionId = TransNullToInt(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()), //题目Id
CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(), //课程Id
Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(), //标准描述
ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(), //控件Id
EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(), //事件Id
ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(), //检查类型Id
ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(), //控件Id
ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(), //控件样式
ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(), //控件值
ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(), //控件html
UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(), //备注
OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()) //序号
};
objge_ExaminationCriteriaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_ExaminationCriteriaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_ExaminationCriteriaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_ExaminationCriteriaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = TransNullToInt(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_ExaminationCriteriaDA: GetObjByDataRowge_ExaminationCriteria)", objException.Message));
}
objge_ExaminationCriteriaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_ExaminationCriteriaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_ExaminationCriteriaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN = new clsge_ExaminationCriteriaEN();
try
{
objge_ExaminationCriteriaEN.CriteriaId = objRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objge_ExaminationCriteriaEN.QuestionId = TransNullToInt(objRow[conge_ExaminationCriteria.QuestionId].ToString().Trim()); //题目Id
objge_ExaminationCriteriaEN.CourseId = objRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objge_ExaminationCriteriaEN.Describe = objRow[conge_ExaminationCriteria.Describe] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objge_ExaminationCriteriaEN.ControlTypeId = objRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.EventTypeId = objRow[conge_ExaminationCriteria.EventTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objge_ExaminationCriteriaEN.ExaminationTypeId = objRow[conge_ExaminationCriteria.ExaminationTypeId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objge_ExaminationCriteriaEN.ControlId = objRow[conge_ExaminationCriteria.ControlId] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objge_ExaminationCriteriaEN.ControlClass = objRow[conge_ExaminationCriteria.ControlClass] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objge_ExaminationCriteriaEN.ControlValue = objRow[conge_ExaminationCriteria.ControlValue] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objge_ExaminationCriteriaEN.ControlHtml = objRow[conge_ExaminationCriteria.ControlHtml] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objge_ExaminationCriteriaEN.UpdDate = objRow[conge_ExaminationCriteria.UpdDate] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objge_ExaminationCriteriaEN.UpdUser = objRow[conge_ExaminationCriteria.UpdUser] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objge_ExaminationCriteriaEN.Memo = objRow[conge_ExaminationCriteria.Memo] == DBNull.Value ? null : objRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objge_ExaminationCriteriaEN.OrderNum = objRow[conge_ExaminationCriteria.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_ExaminationCriteria.OrderNum].ToString().Trim()); //序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_ExaminationCriteriaDA: GetObjByDataRow)", objException.Message));
}
objge_ExaminationCriteriaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_ExaminationCriteriaEN;
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
objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_ExaminationCriteriaEN._CurrTabName, conge_ExaminationCriteria.CriteriaId, 10, "");
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
objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_ExaminationCriteriaEN._CurrTabName, conge_ExaminationCriteria.CriteriaId, 10, strPrefix);
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
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CriteriaId from ge_ExaminationCriteria where " + strCondition;
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
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CriteriaId from ge_ExaminationCriteria where " + strCondition;
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
 /// <param name = "strCriteriaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCriteriaId)
{
CheckPrimaryKey(strCriteriaId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_ExaminationCriteria", "CriteriaId = " + "'"+ strCriteriaId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_ExaminationCriteria", strCondition))
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
objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_ExaminationCriteria");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
 {
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ExaminationCriteriaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_ExaminationCriteria");
objRow = objDS.Tables["ge_ExaminationCriteria"].NewRow();
objRow[conge_ExaminationCriteria.CriteriaId] = objge_ExaminationCriteriaEN.CriteriaId; //标准Id
objRow[conge_ExaminationCriteria.QuestionId] = objge_ExaminationCriteriaEN.QuestionId; //题目Id
objRow[conge_ExaminationCriteria.CourseId] = objge_ExaminationCriteriaEN.CourseId; //课程Id
 if (objge_ExaminationCriteriaEN.Describe !=  "")
 {
objRow[conge_ExaminationCriteria.Describe] = objge_ExaminationCriteriaEN.Describe; //标准描述
 }
objRow[conge_ExaminationCriteria.ControlTypeId] = objge_ExaminationCriteriaEN.ControlTypeId; //控件Id
 if (objge_ExaminationCriteriaEN.EventTypeId !=  "")
 {
objRow[conge_ExaminationCriteria.EventTypeId] = objge_ExaminationCriteriaEN.EventTypeId; //事件Id
 }
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  "")
 {
objRow[conge_ExaminationCriteria.ExaminationTypeId] = objge_ExaminationCriteriaEN.ExaminationTypeId; //检查类型Id
 }
 if (objge_ExaminationCriteriaEN.ControlId !=  "")
 {
objRow[conge_ExaminationCriteria.ControlId] = objge_ExaminationCriteriaEN.ControlId; //控件Id
 }
 if (objge_ExaminationCriteriaEN.ControlClass !=  "")
 {
objRow[conge_ExaminationCriteria.ControlClass] = objge_ExaminationCriteriaEN.ControlClass; //控件样式
 }
 if (objge_ExaminationCriteriaEN.ControlValue !=  "")
 {
objRow[conge_ExaminationCriteria.ControlValue] = objge_ExaminationCriteriaEN.ControlValue; //控件值
 }
 if (objge_ExaminationCriteriaEN.ControlHtml !=  "")
 {
objRow[conge_ExaminationCriteria.ControlHtml] = objge_ExaminationCriteriaEN.ControlHtml; //控件html
 }
 if (objge_ExaminationCriteriaEN.UpdDate !=  "")
 {
objRow[conge_ExaminationCriteria.UpdDate] = objge_ExaminationCriteriaEN.UpdDate; //修改日期
 }
 if (objge_ExaminationCriteriaEN.UpdUser !=  "")
 {
objRow[conge_ExaminationCriteria.UpdUser] = objge_ExaminationCriteriaEN.UpdUser; //修改人
 }
 if (objge_ExaminationCriteriaEN.Memo !=  "")
 {
objRow[conge_ExaminationCriteria.Memo] = objge_ExaminationCriteriaEN.Memo; //备注
 }
objRow[conge_ExaminationCriteria.OrderNum] = objge_ExaminationCriteriaEN.OrderNum; //序号
objDS.Tables[clsge_ExaminationCriteriaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_ExaminationCriteriaEN._CurrTabName);
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ExaminationCriteriaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_ExaminationCriteriaEN.CriteriaId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.CriteriaId);
 var strCriteriaId = objge_ExaminationCriteriaEN.CriteriaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCriteriaId + "'");
 }
 
 arrFieldListForInsert.Add(conge_ExaminationCriteria.QuestionId);
 arrValueListForInsert.Add(objge_ExaminationCriteriaEN.QuestionId.ToString());
 
 if (objge_ExaminationCriteriaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.CourseId);
 var strCourseId = objge_ExaminationCriteriaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.Describe !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.Describe);
 var strDescribe = objge_ExaminationCriteriaEN.Describe.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescribe + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlTypeId);
 var strControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.EventTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.EventTypeId);
 var strEventTypeId = objge_ExaminationCriteriaEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ExaminationTypeId);
 var strExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExaminationTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlId);
 var strControlId = objge_ExaminationCriteriaEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlClass !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlClass);
 var strControlClass = objge_ExaminationCriteriaEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlClass + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlValue !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlValue);
 var strControlValue = objge_ExaminationCriteriaEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlValue + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlHtml !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlHtml);
 var strControlHtml = objge_ExaminationCriteriaEN.ControlHtml.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlHtml + "'");
 }
 
 if (objge_ExaminationCriteriaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.UpdDate);
 var strUpdDate = objge_ExaminationCriteriaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_ExaminationCriteriaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.UpdUser);
 var strUpdUser = objge_ExaminationCriteriaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_ExaminationCriteriaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.Memo);
 var strMemo = objge_ExaminationCriteriaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_ExaminationCriteriaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.OrderNum);
 arrValueListForInsert.Add(objge_ExaminationCriteriaEN.OrderNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_ExaminationCriteria");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ExaminationCriteriaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_ExaminationCriteriaEN.CriteriaId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.CriteriaId);
 var strCriteriaId = objge_ExaminationCriteriaEN.CriteriaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCriteriaId + "'");
 }
 
 arrFieldListForInsert.Add(conge_ExaminationCriteria.QuestionId);
 arrValueListForInsert.Add(objge_ExaminationCriteriaEN.QuestionId.ToString());
 
 if (objge_ExaminationCriteriaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.CourseId);
 var strCourseId = objge_ExaminationCriteriaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.Describe !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.Describe);
 var strDescribe = objge_ExaminationCriteriaEN.Describe.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescribe + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlTypeId);
 var strControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.EventTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.EventTypeId);
 var strEventTypeId = objge_ExaminationCriteriaEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ExaminationTypeId);
 var strExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExaminationTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlId);
 var strControlId = objge_ExaminationCriteriaEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlClass !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlClass);
 var strControlClass = objge_ExaminationCriteriaEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlClass + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlValue !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlValue);
 var strControlValue = objge_ExaminationCriteriaEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlValue + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlHtml !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlHtml);
 var strControlHtml = objge_ExaminationCriteriaEN.ControlHtml.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlHtml + "'");
 }
 
 if (objge_ExaminationCriteriaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.UpdDate);
 var strUpdDate = objge_ExaminationCriteriaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_ExaminationCriteriaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.UpdUser);
 var strUpdUser = objge_ExaminationCriteriaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_ExaminationCriteriaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.Memo);
 var strMemo = objge_ExaminationCriteriaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_ExaminationCriteriaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.OrderNum);
 arrValueListForInsert.Add(objge_ExaminationCriteriaEN.OrderNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_ExaminationCriteria");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objge_ExaminationCriteriaEN.CriteriaId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ExaminationCriteriaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_ExaminationCriteriaEN.CriteriaId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.CriteriaId);
 var strCriteriaId = objge_ExaminationCriteriaEN.CriteriaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCriteriaId + "'");
 }
 
 arrFieldListForInsert.Add(conge_ExaminationCriteria.QuestionId);
 arrValueListForInsert.Add(objge_ExaminationCriteriaEN.QuestionId.ToString());
 
 if (objge_ExaminationCriteriaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.CourseId);
 var strCourseId = objge_ExaminationCriteriaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.Describe !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.Describe);
 var strDescribe = objge_ExaminationCriteriaEN.Describe.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescribe + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlTypeId);
 var strControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.EventTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.EventTypeId);
 var strEventTypeId = objge_ExaminationCriteriaEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ExaminationTypeId);
 var strExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExaminationTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlId);
 var strControlId = objge_ExaminationCriteriaEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlClass !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlClass);
 var strControlClass = objge_ExaminationCriteriaEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlClass + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlValue !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlValue);
 var strControlValue = objge_ExaminationCriteriaEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlValue + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlHtml !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlHtml);
 var strControlHtml = objge_ExaminationCriteriaEN.ControlHtml.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlHtml + "'");
 }
 
 if (objge_ExaminationCriteriaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.UpdDate);
 var strUpdDate = objge_ExaminationCriteriaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_ExaminationCriteriaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.UpdUser);
 var strUpdUser = objge_ExaminationCriteriaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_ExaminationCriteriaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.Memo);
 var strMemo = objge_ExaminationCriteriaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_ExaminationCriteriaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.OrderNum);
 arrValueListForInsert.Add(objge_ExaminationCriteriaEN.OrderNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_ExaminationCriteria");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objge_ExaminationCriteriaEN.CriteriaId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_ExaminationCriteriaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_ExaminationCriteriaEN.CriteriaId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.CriteriaId);
 var strCriteriaId = objge_ExaminationCriteriaEN.CriteriaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCriteriaId + "'");
 }
 
 arrFieldListForInsert.Add(conge_ExaminationCriteria.QuestionId);
 arrValueListForInsert.Add(objge_ExaminationCriteriaEN.QuestionId.ToString());
 
 if (objge_ExaminationCriteriaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.CourseId);
 var strCourseId = objge_ExaminationCriteriaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.Describe !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.Describe);
 var strDescribe = objge_ExaminationCriteriaEN.Describe.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDescribe + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlTypeId);
 var strControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.EventTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.EventTypeId);
 var strEventTypeId = objge_ExaminationCriteriaEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEventTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ExaminationTypeId);
 var strExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExaminationTypeId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlId !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlId);
 var strControlId = objge_ExaminationCriteriaEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlId + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlClass !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlClass);
 var strControlClass = objge_ExaminationCriteriaEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlClass + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlValue !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlValue);
 var strControlValue = objge_ExaminationCriteriaEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlValue + "'");
 }
 
 if (objge_ExaminationCriteriaEN.ControlHtml !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.ControlHtml);
 var strControlHtml = objge_ExaminationCriteriaEN.ControlHtml.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strControlHtml + "'");
 }
 
 if (objge_ExaminationCriteriaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.UpdDate);
 var strUpdDate = objge_ExaminationCriteriaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_ExaminationCriteriaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.UpdUser);
 var strUpdUser = objge_ExaminationCriteriaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_ExaminationCriteriaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.Memo);
 var strMemo = objge_ExaminationCriteriaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_ExaminationCriteriaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_ExaminationCriteria.OrderNum);
 arrValueListForInsert.Add(objge_ExaminationCriteriaEN.OrderNum.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_ExaminationCriteria");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_ExaminationCriterias(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where CriteriaId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_ExaminationCriteria");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCriteriaId = oRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim();
if (IsExist(strCriteriaId))
{
 string strResult = "关键字变量值为:" + string.Format("CriteriaId = {0}", strCriteriaId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_ExaminationCriteriaEN._CurrTabName ].NewRow();
objRow[conge_ExaminationCriteria.CriteriaId] = oRow[conge_ExaminationCriteria.CriteriaId].ToString().Trim(); //标准Id
objRow[conge_ExaminationCriteria.QuestionId] = oRow[conge_ExaminationCriteria.QuestionId].ToString().Trim(); //题目Id
objRow[conge_ExaminationCriteria.CourseId] = oRow[conge_ExaminationCriteria.CourseId].ToString().Trim(); //课程Id
objRow[conge_ExaminationCriteria.Describe] = oRow[conge_ExaminationCriteria.Describe].ToString().Trim(); //标准描述
objRow[conge_ExaminationCriteria.ControlTypeId] = oRow[conge_ExaminationCriteria.ControlTypeId].ToString().Trim(); //控件Id
objRow[conge_ExaminationCriteria.EventTypeId] = oRow[conge_ExaminationCriteria.EventTypeId].ToString().Trim(); //事件Id
objRow[conge_ExaminationCriteria.ExaminationTypeId] = oRow[conge_ExaminationCriteria.ExaminationTypeId].ToString().Trim(); //检查类型Id
objRow[conge_ExaminationCriteria.ControlId] = oRow[conge_ExaminationCriteria.ControlId].ToString().Trim(); //控件Id
objRow[conge_ExaminationCriteria.ControlClass] = oRow[conge_ExaminationCriteria.ControlClass].ToString().Trim(); //控件样式
objRow[conge_ExaminationCriteria.ControlValue] = oRow[conge_ExaminationCriteria.ControlValue].ToString().Trim(); //控件值
objRow[conge_ExaminationCriteria.ControlHtml] = oRow[conge_ExaminationCriteria.ControlHtml].ToString().Trim(); //控件html
objRow[conge_ExaminationCriteria.UpdDate] = oRow[conge_ExaminationCriteria.UpdDate].ToString().Trim(); //修改日期
objRow[conge_ExaminationCriteria.UpdUser] = oRow[conge_ExaminationCriteria.UpdUser].ToString().Trim(); //修改人
objRow[conge_ExaminationCriteria.Memo] = oRow[conge_ExaminationCriteria.Memo].ToString().Trim(); //备注
objRow[conge_ExaminationCriteria.OrderNum] = oRow[conge_ExaminationCriteria.OrderNum].ToString().Trim(); //序号
 objDS.Tables[clsge_ExaminationCriteriaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_ExaminationCriteriaEN._CurrTabName);
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
 /// <param name = "objge_ExaminationCriteriaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ExaminationCriteriaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
strSQL = "Select * from ge_ExaminationCriteria where CriteriaId = " + "'"+ objge_ExaminationCriteriaEN.CriteriaId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_ExaminationCriteriaEN._CurrTabName);
if (objDS.Tables[clsge_ExaminationCriteriaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CriteriaId = " + "'"+ objge_ExaminationCriteriaEN.CriteriaId+"'");
return false;
}
objRow = objDS.Tables[clsge_ExaminationCriteriaEN._CurrTabName].Rows[0];
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.CriteriaId))
 {
objRow[conge_ExaminationCriteria.CriteriaId] = objge_ExaminationCriteriaEN.CriteriaId; //标准Id
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.QuestionId))
 {
objRow[conge_ExaminationCriteria.QuestionId] = objge_ExaminationCriteriaEN.QuestionId; //题目Id
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.CourseId))
 {
objRow[conge_ExaminationCriteria.CourseId] = objge_ExaminationCriteriaEN.CourseId; //课程Id
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Describe))
 {
objRow[conge_ExaminationCriteria.Describe] = objge_ExaminationCriteriaEN.Describe; //标准描述
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlTypeId))
 {
objRow[conge_ExaminationCriteria.ControlTypeId] = objge_ExaminationCriteriaEN.ControlTypeId; //控件Id
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.EventTypeId))
 {
objRow[conge_ExaminationCriteria.EventTypeId] = objge_ExaminationCriteriaEN.EventTypeId; //事件Id
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ExaminationTypeId))
 {
objRow[conge_ExaminationCriteria.ExaminationTypeId] = objge_ExaminationCriteriaEN.ExaminationTypeId; //检查类型Id
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlId))
 {
objRow[conge_ExaminationCriteria.ControlId] = objge_ExaminationCriteriaEN.ControlId; //控件Id
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlClass))
 {
objRow[conge_ExaminationCriteria.ControlClass] = objge_ExaminationCriteriaEN.ControlClass; //控件样式
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlValue))
 {
objRow[conge_ExaminationCriteria.ControlValue] = objge_ExaminationCriteriaEN.ControlValue; //控件值
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlHtml))
 {
objRow[conge_ExaminationCriteria.ControlHtml] = objge_ExaminationCriteriaEN.ControlHtml; //控件html
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdDate))
 {
objRow[conge_ExaminationCriteria.UpdDate] = objge_ExaminationCriteriaEN.UpdDate; //修改日期
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdUser))
 {
objRow[conge_ExaminationCriteria.UpdUser] = objge_ExaminationCriteriaEN.UpdUser; //修改人
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Memo))
 {
objRow[conge_ExaminationCriteria.Memo] = objge_ExaminationCriteriaEN.Memo; //备注
 }
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.OrderNum))
 {
objRow[conge_ExaminationCriteria.OrderNum] = objge_ExaminationCriteriaEN.OrderNum; //序号
 }
try
{
objDA.Update(objDS, clsge_ExaminationCriteriaEN._CurrTabName);
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ExaminationCriteriaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_ExaminationCriteria Set ");
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ExaminationCriteriaEN.QuestionId, conge_ExaminationCriteria.QuestionId); //题目Id
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.CourseId))
 {
 if (objge_ExaminationCriteriaEN.CourseId !=  null)
 {
 var strCourseId = objge_ExaminationCriteriaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_ExaminationCriteria.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.CourseId); //课程Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Describe))
 {
 if (objge_ExaminationCriteriaEN.Describe !=  null)
 {
 var strDescribe = objge_ExaminationCriteriaEN.Describe.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDescribe, conge_ExaminationCriteria.Describe); //标准描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.Describe); //标准描述
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlTypeId))
 {
 if (objge_ExaminationCriteriaEN.ControlTypeId !=  null)
 {
 var strControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlTypeId, conge_ExaminationCriteria.ControlTypeId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlTypeId); //控件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.EventTypeId))
 {
 if (objge_ExaminationCriteriaEN.EventTypeId !=  null)
 {
 var strEventTypeId = objge_ExaminationCriteriaEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEventTypeId, conge_ExaminationCriteria.EventTypeId); //事件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.EventTypeId); //事件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ExaminationTypeId))
 {
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  null)
 {
 var strExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExaminationTypeId, conge_ExaminationCriteria.ExaminationTypeId); //检查类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ExaminationTypeId); //检查类型Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlId))
 {
 if (objge_ExaminationCriteriaEN.ControlId !=  null)
 {
 var strControlId = objge_ExaminationCriteriaEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlId, conge_ExaminationCriteria.ControlId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlId); //控件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlClass))
 {
 if (objge_ExaminationCriteriaEN.ControlClass !=  null)
 {
 var strControlClass = objge_ExaminationCriteriaEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlClass, conge_ExaminationCriteria.ControlClass); //控件样式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlClass); //控件样式
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlValue))
 {
 if (objge_ExaminationCriteriaEN.ControlValue !=  null)
 {
 var strControlValue = objge_ExaminationCriteriaEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlValue, conge_ExaminationCriteria.ControlValue); //控件值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlValue); //控件值
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlHtml))
 {
 if (objge_ExaminationCriteriaEN.ControlHtml !=  null)
 {
 var strControlHtml = objge_ExaminationCriteriaEN.ControlHtml.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlHtml, conge_ExaminationCriteria.ControlHtml); //控件html
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlHtml); //控件html
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdDate))
 {
 if (objge_ExaminationCriteriaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_ExaminationCriteriaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_ExaminationCriteria.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.UpdDate); //修改日期
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdUser))
 {
 if (objge_ExaminationCriteriaEN.UpdUser !=  null)
 {
 var strUpdUser = objge_ExaminationCriteriaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_ExaminationCriteria.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.UpdUser); //修改人
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Memo))
 {
 if (objge_ExaminationCriteriaEN.Memo !=  null)
 {
 var strMemo = objge_ExaminationCriteriaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_ExaminationCriteria.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.Memo); //备注
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.OrderNum))
 {
 if (objge_ExaminationCriteriaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ExaminationCriteriaEN.OrderNum, conge_ExaminationCriteria.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.OrderNum); //序号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CriteriaId = '{0}'", objge_ExaminationCriteriaEN.CriteriaId); 
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
 /// <param name = "objge_ExaminationCriteriaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strCondition)
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ExaminationCriteriaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_ExaminationCriteria Set ");
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_ExaminationCriteriaEN.QuestionId); //题目Id
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.CourseId))
 {
 if (objge_ExaminationCriteriaEN.CourseId !=  null)
 {
 var strCourseId = objge_ExaminationCriteriaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Describe))
 {
 if (objge_ExaminationCriteriaEN.Describe !=  null)
 {
 var strDescribe = objge_ExaminationCriteriaEN.Describe.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Describe = '{0}',", strDescribe); //标准描述
 }
 else
 {
 sbSQL.Append(" Describe = null,"); //标准描述
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlTypeId))
 {
 if (objge_ExaminationCriteriaEN.ControlTypeId !=  null)
 {
 var strControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlTypeId = '{0}',", strControlTypeId); //控件Id
 }
 else
 {
 sbSQL.Append(" ControlTypeId = null,"); //控件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.EventTypeId))
 {
 if (objge_ExaminationCriteriaEN.EventTypeId !=  null)
 {
 var strEventTypeId = objge_ExaminationCriteriaEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EventTypeId = '{0}',", strEventTypeId); //事件Id
 }
 else
 {
 sbSQL.Append(" EventTypeId = null,"); //事件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ExaminationTypeId))
 {
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  null)
 {
 var strExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExaminationTypeId = '{0}',", strExaminationTypeId); //检查类型Id
 }
 else
 {
 sbSQL.Append(" ExaminationTypeId = null,"); //检查类型Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlId))
 {
 if (objge_ExaminationCriteriaEN.ControlId !=  null)
 {
 var strControlId = objge_ExaminationCriteriaEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlId = '{0}',", strControlId); //控件Id
 }
 else
 {
 sbSQL.Append(" ControlId = null,"); //控件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlClass))
 {
 if (objge_ExaminationCriteriaEN.ControlClass !=  null)
 {
 var strControlClass = objge_ExaminationCriteriaEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlClass = '{0}',", strControlClass); //控件样式
 }
 else
 {
 sbSQL.Append(" ControlClass = null,"); //控件样式
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlValue))
 {
 if (objge_ExaminationCriteriaEN.ControlValue !=  null)
 {
 var strControlValue = objge_ExaminationCriteriaEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlValue = '{0}',", strControlValue); //控件值
 }
 else
 {
 sbSQL.Append(" ControlValue = null,"); //控件值
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlHtml))
 {
 if (objge_ExaminationCriteriaEN.ControlHtml !=  null)
 {
 var strControlHtml = objge_ExaminationCriteriaEN.ControlHtml.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlHtml = '{0}',", strControlHtml); //控件html
 }
 else
 {
 sbSQL.Append(" ControlHtml = null,"); //控件html
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdDate))
 {
 if (objge_ExaminationCriteriaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_ExaminationCriteriaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdUser))
 {
 if (objge_ExaminationCriteriaEN.UpdUser !=  null)
 {
 var strUpdUser = objge_ExaminationCriteriaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Memo))
 {
 if (objge_ExaminationCriteriaEN.Memo !=  null)
 {
 var strMemo = objge_ExaminationCriteriaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.OrderNum))
 {
 if (objge_ExaminationCriteriaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ExaminationCriteriaEN.OrderNum, conge_ExaminationCriteria.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.OrderNum); //序号
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
 /// <param name = "objge_ExaminationCriteriaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ExaminationCriteriaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_ExaminationCriteria Set ");
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_ExaminationCriteriaEN.QuestionId); //题目Id
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.CourseId))
 {
 if (objge_ExaminationCriteriaEN.CourseId !=  null)
 {
 var strCourseId = objge_ExaminationCriteriaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Describe))
 {
 if (objge_ExaminationCriteriaEN.Describe !=  null)
 {
 var strDescribe = objge_ExaminationCriteriaEN.Describe.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Describe = '{0}',", strDescribe); //标准描述
 }
 else
 {
 sbSQL.Append(" Describe = null,"); //标准描述
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlTypeId))
 {
 if (objge_ExaminationCriteriaEN.ControlTypeId !=  null)
 {
 var strControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlTypeId = '{0}',", strControlTypeId); //控件Id
 }
 else
 {
 sbSQL.Append(" ControlTypeId = null,"); //控件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.EventTypeId))
 {
 if (objge_ExaminationCriteriaEN.EventTypeId !=  null)
 {
 var strEventTypeId = objge_ExaminationCriteriaEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EventTypeId = '{0}',", strEventTypeId); //事件Id
 }
 else
 {
 sbSQL.Append(" EventTypeId = null,"); //事件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ExaminationTypeId))
 {
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  null)
 {
 var strExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExaminationTypeId = '{0}',", strExaminationTypeId); //检查类型Id
 }
 else
 {
 sbSQL.Append(" ExaminationTypeId = null,"); //检查类型Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlId))
 {
 if (objge_ExaminationCriteriaEN.ControlId !=  null)
 {
 var strControlId = objge_ExaminationCriteriaEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlId = '{0}',", strControlId); //控件Id
 }
 else
 {
 sbSQL.Append(" ControlId = null,"); //控件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlClass))
 {
 if (objge_ExaminationCriteriaEN.ControlClass !=  null)
 {
 var strControlClass = objge_ExaminationCriteriaEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlClass = '{0}',", strControlClass); //控件样式
 }
 else
 {
 sbSQL.Append(" ControlClass = null,"); //控件样式
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlValue))
 {
 if (objge_ExaminationCriteriaEN.ControlValue !=  null)
 {
 var strControlValue = objge_ExaminationCriteriaEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlValue = '{0}',", strControlValue); //控件值
 }
 else
 {
 sbSQL.Append(" ControlValue = null,"); //控件值
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlHtml))
 {
 if (objge_ExaminationCriteriaEN.ControlHtml !=  null)
 {
 var strControlHtml = objge_ExaminationCriteriaEN.ControlHtml.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ControlHtml = '{0}',", strControlHtml); //控件html
 }
 else
 {
 sbSQL.Append(" ControlHtml = null,"); //控件html
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdDate))
 {
 if (objge_ExaminationCriteriaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_ExaminationCriteriaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdUser))
 {
 if (objge_ExaminationCriteriaEN.UpdUser !=  null)
 {
 var strUpdUser = objge_ExaminationCriteriaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Memo))
 {
 if (objge_ExaminationCriteriaEN.Memo !=  null)
 {
 var strMemo = objge_ExaminationCriteriaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.OrderNum))
 {
 if (objge_ExaminationCriteriaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ExaminationCriteriaEN.OrderNum, conge_ExaminationCriteria.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.OrderNum); //序号
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
 /// <param name = "objge_ExaminationCriteriaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_ExaminationCriteriaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_ExaminationCriteriaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_ExaminationCriteria Set ");
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ExaminationCriteriaEN.QuestionId, conge_ExaminationCriteria.QuestionId); //题目Id
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.CourseId))
 {
 if (objge_ExaminationCriteriaEN.CourseId !=  null)
 {
 var strCourseId = objge_ExaminationCriteriaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_ExaminationCriteria.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.CourseId); //课程Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Describe))
 {
 if (objge_ExaminationCriteriaEN.Describe !=  null)
 {
 var strDescribe = objge_ExaminationCriteriaEN.Describe.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDescribe, conge_ExaminationCriteria.Describe); //标准描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.Describe); //标准描述
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlTypeId))
 {
 if (objge_ExaminationCriteriaEN.ControlTypeId !=  null)
 {
 var strControlTypeId = objge_ExaminationCriteriaEN.ControlTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlTypeId, conge_ExaminationCriteria.ControlTypeId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlTypeId); //控件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.EventTypeId))
 {
 if (objge_ExaminationCriteriaEN.EventTypeId !=  null)
 {
 var strEventTypeId = objge_ExaminationCriteriaEN.EventTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEventTypeId, conge_ExaminationCriteria.EventTypeId); //事件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.EventTypeId); //事件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ExaminationTypeId))
 {
 if (objge_ExaminationCriteriaEN.ExaminationTypeId !=  null)
 {
 var strExaminationTypeId = objge_ExaminationCriteriaEN.ExaminationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExaminationTypeId, conge_ExaminationCriteria.ExaminationTypeId); //检查类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ExaminationTypeId); //检查类型Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlId))
 {
 if (objge_ExaminationCriteriaEN.ControlId !=  null)
 {
 var strControlId = objge_ExaminationCriteriaEN.ControlId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlId, conge_ExaminationCriteria.ControlId); //控件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlId); //控件Id
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlClass))
 {
 if (objge_ExaminationCriteriaEN.ControlClass !=  null)
 {
 var strControlClass = objge_ExaminationCriteriaEN.ControlClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlClass, conge_ExaminationCriteria.ControlClass); //控件样式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlClass); //控件样式
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlValue))
 {
 if (objge_ExaminationCriteriaEN.ControlValue !=  null)
 {
 var strControlValue = objge_ExaminationCriteriaEN.ControlValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlValue, conge_ExaminationCriteria.ControlValue); //控件值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlValue); //控件值
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.ControlHtml))
 {
 if (objge_ExaminationCriteriaEN.ControlHtml !=  null)
 {
 var strControlHtml = objge_ExaminationCriteriaEN.ControlHtml.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strControlHtml, conge_ExaminationCriteria.ControlHtml); //控件html
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.ControlHtml); //控件html
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdDate))
 {
 if (objge_ExaminationCriteriaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_ExaminationCriteriaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_ExaminationCriteria.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.UpdDate); //修改日期
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.UpdUser))
 {
 if (objge_ExaminationCriteriaEN.UpdUser !=  null)
 {
 var strUpdUser = objge_ExaminationCriteriaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_ExaminationCriteria.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.UpdUser); //修改人
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.Memo))
 {
 if (objge_ExaminationCriteriaEN.Memo !=  null)
 {
 var strMemo = objge_ExaminationCriteriaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_ExaminationCriteria.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.Memo); //备注
 }
 }
 
 if (objge_ExaminationCriteriaEN.IsUpdated(conge_ExaminationCriteria.OrderNum))
 {
 if (objge_ExaminationCriteriaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_ExaminationCriteriaEN.OrderNum, conge_ExaminationCriteria.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_ExaminationCriteria.OrderNum); //序号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CriteriaId = '{0}'", objge_ExaminationCriteriaEN.CriteriaId); 
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
 /// <param name = "strCriteriaId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCriteriaId) 
{
CheckPrimaryKey(strCriteriaId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCriteriaId,
};
 objSQL.ExecSP("ge_ExaminationCriteria_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCriteriaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCriteriaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCriteriaId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
//删除ge_ExaminationCriteria本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_ExaminationCriteria where CriteriaId = " + "'"+ strCriteriaId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_ExaminationCriteria(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
//删除ge_ExaminationCriteria本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_ExaminationCriteria where CriteriaId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCriteriaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCriteriaId) 
{
CheckPrimaryKey(strCriteriaId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
//删除ge_ExaminationCriteria本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_ExaminationCriteria where CriteriaId = " + "'"+ strCriteriaId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_ExaminationCriteria(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: Delge_ExaminationCriteria)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_ExaminationCriteria where " + strCondition ;
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
public bool Delge_ExaminationCriteriaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_ExaminationCriteriaDA: Delge_ExaminationCriteriaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_ExaminationCriteria where " + strCondition ;
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
 /// <param name = "objge_ExaminationCriteriaENS">源对象</param>
 /// <param name = "objge_ExaminationCriteriaENT">目标对象</param>
public void CopyTo(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENS, clsge_ExaminationCriteriaEN objge_ExaminationCriteriaENT)
{
objge_ExaminationCriteriaENT.CriteriaId = objge_ExaminationCriteriaENS.CriteriaId; //标准Id
objge_ExaminationCriteriaENT.QuestionId = objge_ExaminationCriteriaENS.QuestionId; //题目Id
objge_ExaminationCriteriaENT.CourseId = objge_ExaminationCriteriaENS.CourseId; //课程Id
objge_ExaminationCriteriaENT.Describe = objge_ExaminationCriteriaENS.Describe; //标准描述
objge_ExaminationCriteriaENT.ControlTypeId = objge_ExaminationCriteriaENS.ControlTypeId; //控件Id
objge_ExaminationCriteriaENT.EventTypeId = objge_ExaminationCriteriaENS.EventTypeId; //事件Id
objge_ExaminationCriteriaENT.ExaminationTypeId = objge_ExaminationCriteriaENS.ExaminationTypeId; //检查类型Id
objge_ExaminationCriteriaENT.ControlId = objge_ExaminationCriteriaENS.ControlId; //控件Id
objge_ExaminationCriteriaENT.ControlClass = objge_ExaminationCriteriaENS.ControlClass; //控件样式
objge_ExaminationCriteriaENT.ControlValue = objge_ExaminationCriteriaENS.ControlValue; //控件值
objge_ExaminationCriteriaENT.ControlHtml = objge_ExaminationCriteriaENS.ControlHtml; //控件html
objge_ExaminationCriteriaENT.UpdDate = objge_ExaminationCriteriaENS.UpdDate; //修改日期
objge_ExaminationCriteriaENT.UpdUser = objge_ExaminationCriteriaENS.UpdUser; //修改人
objge_ExaminationCriteriaENT.Memo = objge_ExaminationCriteriaENS.Memo; //备注
objge_ExaminationCriteriaENT.OrderNum = objge_ExaminationCriteriaENS.OrderNum; //序号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_ExaminationCriteriaEN.QuestionId, conge_ExaminationCriteria.QuestionId);
clsCheckSql.CheckFieldNotNull(objge_ExaminationCriteriaEN.CourseId, conge_ExaminationCriteria.CourseId);
clsCheckSql.CheckFieldNotNull(objge_ExaminationCriteriaEN.ControlTypeId, conge_ExaminationCriteria.ControlTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.CriteriaId, 10, conge_ExaminationCriteria.CriteriaId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.CourseId, 8, conge_ExaminationCriteria.CourseId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.Describe, 1000, conge_ExaminationCriteria.Describe);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlTypeId, 4, conge_ExaminationCriteria.ControlTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.EventTypeId, 4, conge_ExaminationCriteria.EventTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ExaminationTypeId, 4, conge_ExaminationCriteria.ExaminationTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlId, 50, conge_ExaminationCriteria.ControlId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlClass, 100, conge_ExaminationCriteria.ControlClass);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlValue, 100, conge_ExaminationCriteria.ControlValue);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlHtml, 100, conge_ExaminationCriteria.ControlHtml);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.UpdDate, 20, conge_ExaminationCriteria.UpdDate);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.UpdUser, 20, conge_ExaminationCriteria.UpdUser);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.Memo, 1000, conge_ExaminationCriteria.Memo);
//检查字段外键固定长度
 objge_ExaminationCriteriaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.CourseId, 8, conge_ExaminationCriteria.CourseId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.Describe, 1000, conge_ExaminationCriteria.Describe);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlTypeId, 4, conge_ExaminationCriteria.ControlTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.EventTypeId, 4, conge_ExaminationCriteria.EventTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ExaminationTypeId, 4, conge_ExaminationCriteria.ExaminationTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlId, 50, conge_ExaminationCriteria.ControlId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlClass, 100, conge_ExaminationCriteria.ControlClass);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlValue, 100, conge_ExaminationCriteria.ControlValue);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlHtml, 100, conge_ExaminationCriteria.ControlHtml);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.UpdDate, 20, conge_ExaminationCriteria.UpdDate);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.UpdUser, 20, conge_ExaminationCriteria.UpdUser);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.Memo, 1000, conge_ExaminationCriteria.Memo);
//检查外键字段长度
 objge_ExaminationCriteriaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.CriteriaId, 10, conge_ExaminationCriteria.CriteriaId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.CourseId, 8, conge_ExaminationCriteria.CourseId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.Describe, 1000, conge_ExaminationCriteria.Describe);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlTypeId, 4, conge_ExaminationCriteria.ControlTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.EventTypeId, 4, conge_ExaminationCriteria.EventTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ExaminationTypeId, 4, conge_ExaminationCriteria.ExaminationTypeId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlId, 50, conge_ExaminationCriteria.ControlId);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlClass, 100, conge_ExaminationCriteria.ControlClass);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlValue, 100, conge_ExaminationCriteria.ControlValue);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.ControlHtml, 100, conge_ExaminationCriteria.ControlHtml);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.UpdDate, 20, conge_ExaminationCriteria.UpdDate);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.UpdUser, 20, conge_ExaminationCriteria.UpdUser);
clsCheckSql.CheckFieldLen(objge_ExaminationCriteriaEN.Memo, 1000, conge_ExaminationCriteria.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.CriteriaId, conge_ExaminationCriteria.CriteriaId);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.CourseId, conge_ExaminationCriteria.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.Describe, conge_ExaminationCriteria.Describe);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.ControlTypeId, conge_ExaminationCriteria.ControlTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.EventTypeId, conge_ExaminationCriteria.EventTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.ExaminationTypeId, conge_ExaminationCriteria.ExaminationTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.ControlId, conge_ExaminationCriteria.ControlId);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.ControlClass, conge_ExaminationCriteria.ControlClass);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.ControlValue, conge_ExaminationCriteria.ControlValue);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.ControlHtml, conge_ExaminationCriteria.ControlHtml);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.UpdDate, conge_ExaminationCriteria.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.UpdUser, conge_ExaminationCriteria.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_ExaminationCriteriaEN.Memo, conge_ExaminationCriteria.Memo);
//检查外键字段长度
 objge_ExaminationCriteriaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_ExaminationCriteria(题目检查标准表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_ExaminationCriteriaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_ExaminationCriteriaEN objge_ExaminationCriteriaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_ExaminationCriteriaEN.QuestionId);
 sbCondition.AppendFormat(" and ControlTypeId = '{0}'", objge_ExaminationCriteriaEN.ControlTypeId);
 if (objge_ExaminationCriteriaEN.EventTypeId == null)
{
 sbCondition.AppendFormat(" and EventTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and EventTypeId = '{0}'", objge_ExaminationCriteriaEN.EventTypeId);
}
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
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_ExaminationCriteriaEN._CurrTabName);
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
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_ExaminationCriteriaEN._CurrTabName, strCondition);
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
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
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
 objSQL = clsge_ExaminationCriteriaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}