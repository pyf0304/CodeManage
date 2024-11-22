
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureGraphDA
 表名:ge_StructureGraph(01120895)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:10
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
 /// 结构图谱表(ge_StructureGraph)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_StructureGraphDA : clsCommBase4DA
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
 return clsge_StructureGraphEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_StructureGraphEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StructureGraphEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_StructureGraphEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_StructureGraphEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strStructureGraphId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strStructureGraphId)
{
strStructureGraphId = strStructureGraphId.Replace("'", "''");
if (strStructureGraphId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:ge_StructureGraph中,检查关键字,长度不正确!(clsge_StructureGraphDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strStructureGraphId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ge_StructureGraph中,关键字不能为空 或 null!(clsge_StructureGraphDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStructureGraphId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsge_StructureGraphDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_StructureGraph(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTable_ge_StructureGraph)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureGraph where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureGraph where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_StructureGraph where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_StructureGraph.* from ge_StructureGraph Left Join {1} on {2} where {3} and ge_StructureGraph.StructureGraphId not in (Select top {5} ge_StructureGraph.StructureGraphId from ge_StructureGraph Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureGraph where {1} and StructureGraphId not in (Select top {2} StructureGraphId from ge_StructureGraph where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureGraph where {1} and StructureGraphId not in (Select top {3} StructureGraphId from ge_StructureGraph where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_StructureGraph.* from ge_StructureGraph Left Join {1} on {2} where {3} and ge_StructureGraph.StructureGraphId not in (Select top {5} ge_StructureGraph.StructureGraphId from ge_StructureGraph Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureGraph where {1} and StructureGraphId not in (Select top {2} StructureGraphId from ge_StructureGraph where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_StructureGraph where {1} and StructureGraphId not in (Select top {3} StructureGraphId from ge_StructureGraph where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_StructureGraphEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_StructureGraphDA:GetObjLst)", objException.Message));
}
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = TransNullToBool(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = TransNullToBool(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = TransNullToBool(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = TransNullToBool(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_StructureGraphDA: GetObjLst)", objException.Message));
}
objge_StructureGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_StructureGraphEN);
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
public List<clsge_StructureGraphEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_StructureGraphDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_StructureGraphEN> arrObjLst = new List<clsge_StructureGraphEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = TransNullToBool(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = TransNullToBool(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = TransNullToBool(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = TransNullToBool(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_StructureGraphDA: GetObjLst)", objException.Message));
}
objge_StructureGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_StructureGraphEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_StructureGraph(ref clsge_StructureGraphEN objge_StructureGraphEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where StructureGraphId = " + "'"+ objge_StructureGraphEN.StructureGraphId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_StructureGraphEN.StructureGraphId = objDT.Rows[0][conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureGraphEN.StructureGraphName = objDT.Rows[0][conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称(字段类型:varchar,字段长度:100,是否可空:True)
 objge_StructureGraphEN.IdCurrEduCls = objDT.Rows[0][conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_StructureGraphEN.CourseId = objDT.Rows[0][conge_StructureGraph.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StructureGraphEN.CreateUser = objDT.Rows[0][conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureGraphEN.UpdDate = objDT.Rows[0][conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureGraphEN.UpdUser = objDT.Rows[0][conge_StructureGraph.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureGraphEN.Memo = objDT.Rows[0][conge_StructureGraph.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_StructureGraphEN.GraphTypeId = objDT.Rows[0][conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id(字段类型:char,字段长度:2,是否可空:False)
 objge_StructureGraphEN.IsDisplay = TransNullToBool(objDT.Rows[0][conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureGraphEN.IsExtend = TransNullToBool(objDT.Rows[0][conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureGraphEN.IsRecommend = TransNullToBool(objDT.Rows[0][conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureGraphEN.Theme = objDT.Rows[0][conge_StructureGraph.Theme].ToString().Trim(); //主题(字段类型:varchar,字段长度:100,是否可空:True)
 objge_StructureGraphEN.IsSubmit = TransNullToBool(objDT.Rows[0][conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureGraphEN.SectionTypeId = objDT.Rows[0][conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StructureGraphEN.TakeUpTime = objDT.Rows[0][conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureGraphEN.StartTime = objDT.Rows[0][conge_StructureGraph.StartTime].ToString().Trim(); //开始时间(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureGraphEN.SubmitTime = objDT.Rows[0][conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_StructureGraphDA: Getge_StructureGraph)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strStructureGraphId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_StructureGraphEN GetObjByStructureGraphId(string strStructureGraphId)
{
CheckPrimaryKey(strStructureGraphId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where StructureGraphId = " + "'"+ strStructureGraphId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
 objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id(字段类型:char,字段长度:10,是否可空:True)
 objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称(字段类型:varchar,字段长度:100,是否可空:True)
 objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id(字段类型:char,字段长度:2,是否可空:False)
 objge_StructureGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题(字段类型:varchar,字段长度:100,是否可空:True)
 objge_StructureGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id(字段类型:char,字段长度:8,是否可空:True)
 objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时(字段类型:varchar,字段长度:50,是否可空:True)
 objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间(字段类型:varchar,字段长度:20,是否可空:True)
 objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_StructureGraphDA: GetObjByStructureGraphId)", objException.Message));
}
return objge_StructureGraphEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_StructureGraphEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN()
{
StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(), //知识图谱Id
StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(), //结构图谱名称
IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(), //教学班流水号
CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(), //课程Id
CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(), //建立用户
UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(), //备注
GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(), //图谱类型Id
IsDisplay = TransNullToBool(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()), //是否显示
IsExtend = TransNullToBool(objRow[conge_StructureGraph.IsExtend].ToString().Trim()), //是否扩展
IsRecommend = TransNullToBool(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()), //是否推荐
Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(), //主题
IsSubmit = TransNullToBool(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()), //是否提交
SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(), //节点类型Id
TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(), //耗时
StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(), //开始时间
SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim() //提交时间
};
objge_StructureGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StructureGraphEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_StructureGraphDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_StructureGraphEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = TransNullToBool(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = TransNullToBool(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = TransNullToBool(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = TransNullToBool(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_StructureGraphDA: GetObjByDataRowge_StructureGraph)", objException.Message));
}
objge_StructureGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StructureGraphEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_StructureGraphEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_StructureGraphEN objge_StructureGraphEN = new clsge_StructureGraphEN();
try
{
objge_StructureGraphEN.StructureGraphId = objRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureGraphEN.StructureGraphName = objRow[conge_StructureGraph.StructureGraphName] == DBNull.Value ? null : objRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objge_StructureGraphEN.IdCurrEduCls = objRow[conge_StructureGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_StructureGraphEN.CourseId = objRow[conge_StructureGraph.CourseId] == DBNull.Value ? null : objRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objge_StructureGraphEN.CreateUser = objRow[conge_StructureGraph.CreateUser] == DBNull.Value ? null : objRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objge_StructureGraphEN.UpdDate = objRow[conge_StructureGraph.UpdDate] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objge_StructureGraphEN.UpdUser = objRow[conge_StructureGraph.UpdUser] == DBNull.Value ? null : objRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objge_StructureGraphEN.Memo = objRow[conge_StructureGraph.Memo] == DBNull.Value ? null : objRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objge_StructureGraphEN.GraphTypeId = objRow[conge_StructureGraph.GraphTypeId] == DBNull.Value ? null : objRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objge_StructureGraphEN.IsDisplay = TransNullToBool(objRow[conge_StructureGraph.IsDisplay].ToString().Trim()); //是否显示
objge_StructureGraphEN.IsExtend = TransNullToBool(objRow[conge_StructureGraph.IsExtend].ToString().Trim()); //是否扩展
objge_StructureGraphEN.IsRecommend = TransNullToBool(objRow[conge_StructureGraph.IsRecommend].ToString().Trim()); //是否推荐
objge_StructureGraphEN.Theme = objRow[conge_StructureGraph.Theme] == DBNull.Value ? null : objRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objge_StructureGraphEN.IsSubmit = TransNullToBool(objRow[conge_StructureGraph.IsSubmit].ToString().Trim()); //是否提交
objge_StructureGraphEN.SectionTypeId = objRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objge_StructureGraphEN.TakeUpTime = objRow[conge_StructureGraph.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objge_StructureGraphEN.StartTime = objRow[conge_StructureGraph.StartTime] == DBNull.Value ? null : objRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objge_StructureGraphEN.SubmitTime = objRow[conge_StructureGraph.SubmitTime] == DBNull.Value ? null : objRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_StructureGraphDA: GetObjByDataRow)", objException.Message));
}
objge_StructureGraphEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_StructureGraphEN;
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
objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_StructureGraphEN._CurrTabName, conge_StructureGraph.StructureGraphId, 10, "");
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
objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_StructureGraphEN._CurrTabName, conge_StructureGraph.StructureGraphId, 10, strPrefix);
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
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select StructureGraphId from ge_StructureGraph where " + strCondition;
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
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select StructureGraphId from ge_StructureGraph where " + strCondition;
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
 /// <param name = "strStructureGraphId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strStructureGraphId)
{
CheckPrimaryKey(strStructureGraphId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_StructureGraph", "StructureGraphId = " + "'"+ strStructureGraphId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_StructureGraphDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_StructureGraph", strCondition))
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
objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_StructureGraph");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_StructureGraphEN objge_StructureGraphEN)
 {
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureGraphEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_StructureGraph");
objRow = objDS.Tables["ge_StructureGraph"].NewRow();
objRow[conge_StructureGraph.StructureGraphId] = objge_StructureGraphEN.StructureGraphId; //知识图谱Id
 if (objge_StructureGraphEN.StructureGraphName !=  "")
 {
objRow[conge_StructureGraph.StructureGraphName] = objge_StructureGraphEN.StructureGraphName; //结构图谱名称
 }
 if (objge_StructureGraphEN.IdCurrEduCls !=  "")
 {
objRow[conge_StructureGraph.IdCurrEduCls] = objge_StructureGraphEN.IdCurrEduCls; //教学班流水号
 }
 if (objge_StructureGraphEN.CourseId !=  "")
 {
objRow[conge_StructureGraph.CourseId] = objge_StructureGraphEN.CourseId; //课程Id
 }
 if (objge_StructureGraphEN.CreateUser !=  "")
 {
objRow[conge_StructureGraph.CreateUser] = objge_StructureGraphEN.CreateUser; //建立用户
 }
 if (objge_StructureGraphEN.UpdDate !=  "")
 {
objRow[conge_StructureGraph.UpdDate] = objge_StructureGraphEN.UpdDate; //修改日期
 }
 if (objge_StructureGraphEN.UpdUser !=  "")
 {
objRow[conge_StructureGraph.UpdUser] = objge_StructureGraphEN.UpdUser; //修改人
 }
 if (objge_StructureGraphEN.Memo !=  "")
 {
objRow[conge_StructureGraph.Memo] = objge_StructureGraphEN.Memo; //备注
 }
 if (objge_StructureGraphEN.GraphTypeId !=  "")
 {
objRow[conge_StructureGraph.GraphTypeId] = objge_StructureGraphEN.GraphTypeId; //图谱类型Id
 }
objRow[conge_StructureGraph.IsDisplay] = objge_StructureGraphEN.IsDisplay; //是否显示
objRow[conge_StructureGraph.IsExtend] = objge_StructureGraphEN.IsExtend; //是否扩展
objRow[conge_StructureGraph.IsRecommend] = objge_StructureGraphEN.IsRecommend; //是否推荐
 if (objge_StructureGraphEN.Theme !=  "")
 {
objRow[conge_StructureGraph.Theme] = objge_StructureGraphEN.Theme; //主题
 }
objRow[conge_StructureGraph.IsSubmit] = objge_StructureGraphEN.IsSubmit; //是否提交
objRow[conge_StructureGraph.SectionTypeId] = objge_StructureGraphEN.SectionTypeId; //节点类型Id
 if (objge_StructureGraphEN.TakeUpTime !=  "")
 {
objRow[conge_StructureGraph.TakeUpTime] = objge_StructureGraphEN.TakeUpTime; //耗时
 }
 if (objge_StructureGraphEN.StartTime !=  "")
 {
objRow[conge_StructureGraph.StartTime] = objge_StructureGraphEN.StartTime; //开始时间
 }
 if (objge_StructureGraphEN.SubmitTime !=  "")
 {
objRow[conge_StructureGraph.SubmitTime] = objge_StructureGraphEN.SubmitTime; //提交时间
 }
objDS.Tables[clsge_StructureGraphEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_StructureGraphEN._CurrTabName);
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_StructureGraphEN objge_StructureGraphEN)
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureGraphEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_StructureGraphEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StructureGraphId);
 var strStructureGraphId = objge_StructureGraphEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_StructureGraphEN.StructureGraphName !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StructureGraphName);
 var strStructureGraphName = objge_StructureGraphEN.StructureGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphName + "'");
 }
 
 if (objge_StructureGraphEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.IdCurrEduCls);
 var strIdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_StructureGraphEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.CourseId);
 var strCourseId = objge_StructureGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StructureGraphEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.CreateUser);
 var strCreateUser = objge_StructureGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objge_StructureGraphEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.UpdDate);
 var strUpdDate = objge_StructureGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StructureGraphEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.UpdUser);
 var strUpdUser = objge_StructureGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StructureGraphEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.Memo);
 var strMemo = objge_StructureGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_StructureGraphEN.GraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.GraphTypeId);
 var strGraphTypeId = objge_StructureGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraphTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsDisplay);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsDisplay  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsExtend);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureGraphEN.Theme !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.Theme);
 var strTheme = objge_StructureGraphEN.Theme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTheme + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureGraphEN.SectionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.SectionTypeId);
 var strSectionTypeId = objge_StructureGraphEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionTypeId + "'");
 }
 
 if (objge_StructureGraphEN.TakeUpTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.TakeUpTime);
 var strTakeUpTime = objge_StructureGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTakeUpTime + "'");
 }
 
 if (objge_StructureGraphEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StartTime);
 var strStartTime = objge_StructureGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objge_StructureGraphEN.SubmitTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.SubmitTime);
 var strSubmitTime = objge_StructureGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StructureGraph");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_StructureGraphEN objge_StructureGraphEN)
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureGraphEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_StructureGraphEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StructureGraphId);
 var strStructureGraphId = objge_StructureGraphEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_StructureGraphEN.StructureGraphName !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StructureGraphName);
 var strStructureGraphName = objge_StructureGraphEN.StructureGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphName + "'");
 }
 
 if (objge_StructureGraphEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.IdCurrEduCls);
 var strIdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_StructureGraphEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.CourseId);
 var strCourseId = objge_StructureGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StructureGraphEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.CreateUser);
 var strCreateUser = objge_StructureGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objge_StructureGraphEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.UpdDate);
 var strUpdDate = objge_StructureGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StructureGraphEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.UpdUser);
 var strUpdUser = objge_StructureGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StructureGraphEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.Memo);
 var strMemo = objge_StructureGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_StructureGraphEN.GraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.GraphTypeId);
 var strGraphTypeId = objge_StructureGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraphTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsDisplay);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsDisplay  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsExtend);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureGraphEN.Theme !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.Theme);
 var strTheme = objge_StructureGraphEN.Theme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTheme + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureGraphEN.SectionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.SectionTypeId);
 var strSectionTypeId = objge_StructureGraphEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionTypeId + "'");
 }
 
 if (objge_StructureGraphEN.TakeUpTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.TakeUpTime);
 var strTakeUpTime = objge_StructureGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTakeUpTime + "'");
 }
 
 if (objge_StructureGraphEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StartTime);
 var strStartTime = objge_StructureGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objge_StructureGraphEN.SubmitTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.SubmitTime);
 var strSubmitTime = objge_StructureGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StructureGraph");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objge_StructureGraphEN.StructureGraphId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_StructureGraphEN objge_StructureGraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureGraphEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_StructureGraphEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StructureGraphId);
 var strStructureGraphId = objge_StructureGraphEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_StructureGraphEN.StructureGraphName !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StructureGraphName);
 var strStructureGraphName = objge_StructureGraphEN.StructureGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphName + "'");
 }
 
 if (objge_StructureGraphEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.IdCurrEduCls);
 var strIdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_StructureGraphEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.CourseId);
 var strCourseId = objge_StructureGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StructureGraphEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.CreateUser);
 var strCreateUser = objge_StructureGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objge_StructureGraphEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.UpdDate);
 var strUpdDate = objge_StructureGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StructureGraphEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.UpdUser);
 var strUpdUser = objge_StructureGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StructureGraphEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.Memo);
 var strMemo = objge_StructureGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_StructureGraphEN.GraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.GraphTypeId);
 var strGraphTypeId = objge_StructureGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraphTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsDisplay);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsDisplay  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsExtend);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureGraphEN.Theme !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.Theme);
 var strTheme = objge_StructureGraphEN.Theme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTheme + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureGraphEN.SectionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.SectionTypeId);
 var strSectionTypeId = objge_StructureGraphEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionTypeId + "'");
 }
 
 if (objge_StructureGraphEN.TakeUpTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.TakeUpTime);
 var strTakeUpTime = objge_StructureGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTakeUpTime + "'");
 }
 
 if (objge_StructureGraphEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StartTime);
 var strStartTime = objge_StructureGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objge_StructureGraphEN.SubmitTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.SubmitTime);
 var strSubmitTime = objge_StructureGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StructureGraph");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objge_StructureGraphEN.StructureGraphId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_StructureGraphEN objge_StructureGraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_StructureGraphEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_StructureGraphEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StructureGraphId);
 var strStructureGraphId = objge_StructureGraphEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_StructureGraphEN.StructureGraphName !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StructureGraphName);
 var strStructureGraphName = objge_StructureGraphEN.StructureGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphName + "'");
 }
 
 if (objge_StructureGraphEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.IdCurrEduCls);
 var strIdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_StructureGraphEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.CourseId);
 var strCourseId = objge_StructureGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_StructureGraphEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.CreateUser);
 var strCreateUser = objge_StructureGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objge_StructureGraphEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.UpdDate);
 var strUpdDate = objge_StructureGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_StructureGraphEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.UpdUser);
 var strUpdUser = objge_StructureGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_StructureGraphEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.Memo);
 var strMemo = objge_StructureGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_StructureGraphEN.GraphTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.GraphTypeId);
 var strGraphTypeId = objge_StructureGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraphTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsDisplay);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsDisplay  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsExtend);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureGraphEN.Theme !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.Theme);
 var strTheme = objge_StructureGraphEN.Theme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTheme + "'");
 }
 
 arrFieldListForInsert.Add(conge_StructureGraph.IsSubmit);
 arrValueListForInsert.Add("'" + (objge_StructureGraphEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objge_StructureGraphEN.SectionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.SectionTypeId);
 var strSectionTypeId = objge_StructureGraphEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSectionTypeId + "'");
 }
 
 if (objge_StructureGraphEN.TakeUpTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.TakeUpTime);
 var strTakeUpTime = objge_StructureGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTakeUpTime + "'");
 }
 
 if (objge_StructureGraphEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.StartTime);
 var strStartTime = objge_StructureGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objge_StructureGraphEN.SubmitTime !=  null)
 {
 arrFieldListForInsert.Add(conge_StructureGraph.SubmitTime);
 var strSubmitTime = objge_StructureGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_StructureGraph");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_StructureGraphs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where StructureGraphId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_StructureGraph");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strStructureGraphId = oRow[conge_StructureGraph.StructureGraphId].ToString().Trim();
if (IsExist(strStructureGraphId))
{
 string strResult = "关键字变量值为:" + string.Format("StructureGraphId = {0}", strStructureGraphId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_StructureGraphEN._CurrTabName ].NewRow();
objRow[conge_StructureGraph.StructureGraphId] = oRow[conge_StructureGraph.StructureGraphId].ToString().Trim(); //知识图谱Id
objRow[conge_StructureGraph.StructureGraphName] = oRow[conge_StructureGraph.StructureGraphName].ToString().Trim(); //结构图谱名称
objRow[conge_StructureGraph.IdCurrEduCls] = oRow[conge_StructureGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conge_StructureGraph.CourseId] = oRow[conge_StructureGraph.CourseId].ToString().Trim(); //课程Id
objRow[conge_StructureGraph.CreateUser] = oRow[conge_StructureGraph.CreateUser].ToString().Trim(); //建立用户
objRow[conge_StructureGraph.UpdDate] = oRow[conge_StructureGraph.UpdDate].ToString().Trim(); //修改日期
objRow[conge_StructureGraph.UpdUser] = oRow[conge_StructureGraph.UpdUser].ToString().Trim(); //修改人
objRow[conge_StructureGraph.Memo] = oRow[conge_StructureGraph.Memo].ToString().Trim(); //备注
objRow[conge_StructureGraph.GraphTypeId] = oRow[conge_StructureGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objRow[conge_StructureGraph.IsDisplay] = oRow[conge_StructureGraph.IsDisplay].ToString().Trim(); //是否显示
objRow[conge_StructureGraph.IsExtend] = oRow[conge_StructureGraph.IsExtend].ToString().Trim(); //是否扩展
objRow[conge_StructureGraph.IsRecommend] = oRow[conge_StructureGraph.IsRecommend].ToString().Trim(); //是否推荐
objRow[conge_StructureGraph.Theme] = oRow[conge_StructureGraph.Theme].ToString().Trim(); //主题
objRow[conge_StructureGraph.IsSubmit] = oRow[conge_StructureGraph.IsSubmit].ToString().Trim(); //是否提交
objRow[conge_StructureGraph.SectionTypeId] = oRow[conge_StructureGraph.SectionTypeId].ToString().Trim(); //节点类型Id
objRow[conge_StructureGraph.TakeUpTime] = oRow[conge_StructureGraph.TakeUpTime].ToString().Trim(); //耗时
objRow[conge_StructureGraph.StartTime] = oRow[conge_StructureGraph.StartTime].ToString().Trim(); //开始时间
objRow[conge_StructureGraph.SubmitTime] = oRow[conge_StructureGraph.SubmitTime].ToString().Trim(); //提交时间
 objDS.Tables[clsge_StructureGraphEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_StructureGraphEN._CurrTabName);
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
 /// <param name = "objge_StructureGraphEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_StructureGraphEN objge_StructureGraphEN)
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureGraphEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
strSQL = "Select * from ge_StructureGraph where StructureGraphId = " + "'"+ objge_StructureGraphEN.StructureGraphId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_StructureGraphEN._CurrTabName);
if (objDS.Tables[clsge_StructureGraphEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:StructureGraphId = " + "'"+ objge_StructureGraphEN.StructureGraphId+"'");
return false;
}
objRow = objDS.Tables[clsge_StructureGraphEN._CurrTabName].Rows[0];
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StructureGraphId))
 {
objRow[conge_StructureGraph.StructureGraphId] = objge_StructureGraphEN.StructureGraphId; //知识图谱Id
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StructureGraphName))
 {
objRow[conge_StructureGraph.StructureGraphName] = objge_StructureGraphEN.StructureGraphName; //结构图谱名称
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IdCurrEduCls))
 {
objRow[conge_StructureGraph.IdCurrEduCls] = objge_StructureGraphEN.IdCurrEduCls; //教学班流水号
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CourseId))
 {
objRow[conge_StructureGraph.CourseId] = objge_StructureGraphEN.CourseId; //课程Id
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CreateUser))
 {
objRow[conge_StructureGraph.CreateUser] = objge_StructureGraphEN.CreateUser; //建立用户
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdDate))
 {
objRow[conge_StructureGraph.UpdDate] = objge_StructureGraphEN.UpdDate; //修改日期
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdUser))
 {
objRow[conge_StructureGraph.UpdUser] = objge_StructureGraphEN.UpdUser; //修改人
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Memo))
 {
objRow[conge_StructureGraph.Memo] = objge_StructureGraphEN.Memo; //备注
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.GraphTypeId))
 {
objRow[conge_StructureGraph.GraphTypeId] = objge_StructureGraphEN.GraphTypeId; //图谱类型Id
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsDisplay))
 {
objRow[conge_StructureGraph.IsDisplay] = objge_StructureGraphEN.IsDisplay; //是否显示
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsExtend))
 {
objRow[conge_StructureGraph.IsExtend] = objge_StructureGraphEN.IsExtend; //是否扩展
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsRecommend))
 {
objRow[conge_StructureGraph.IsRecommend] = objge_StructureGraphEN.IsRecommend; //是否推荐
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Theme))
 {
objRow[conge_StructureGraph.Theme] = objge_StructureGraphEN.Theme; //主题
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsSubmit))
 {
objRow[conge_StructureGraph.IsSubmit] = objge_StructureGraphEN.IsSubmit; //是否提交
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SectionTypeId))
 {
objRow[conge_StructureGraph.SectionTypeId] = objge_StructureGraphEN.SectionTypeId; //节点类型Id
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.TakeUpTime))
 {
objRow[conge_StructureGraph.TakeUpTime] = objge_StructureGraphEN.TakeUpTime; //耗时
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StartTime))
 {
objRow[conge_StructureGraph.StartTime] = objge_StructureGraphEN.StartTime; //开始时间
 }
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SubmitTime))
 {
objRow[conge_StructureGraph.SubmitTime] = objge_StructureGraphEN.SubmitTime; //提交时间
 }
try
{
objDA.Update(objDS, clsge_StructureGraphEN._CurrTabName);
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_StructureGraphEN objge_StructureGraphEN)
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureGraphEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_StructureGraph Set ");
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StructureGraphName))
 {
 if (objge_StructureGraphEN.StructureGraphName !=  null)
 {
 var strStructureGraphName = objge_StructureGraphEN.StructureGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureGraphName, conge_StructureGraph.StructureGraphName); //结构图谱名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.StructureGraphName); //结构图谱名称
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IdCurrEduCls))
 {
 if (objge_StructureGraphEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conge_StructureGraph.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CourseId))
 {
 if (objge_StructureGraphEN.CourseId !=  null)
 {
 var strCourseId = objge_StructureGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_StructureGraph.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.CourseId); //课程Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CreateUser))
 {
 if (objge_StructureGraphEN.CreateUser !=  null)
 {
 var strCreateUser = objge_StructureGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUser, conge_StructureGraph.CreateUser); //建立用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.CreateUser); //建立用户
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdDate))
 {
 if (objge_StructureGraphEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StructureGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_StructureGraph.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.UpdDate); //修改日期
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdUser))
 {
 if (objge_StructureGraphEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StructureGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_StructureGraph.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.UpdUser); //修改人
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Memo))
 {
 if (objge_StructureGraphEN.Memo !=  null)
 {
 var strMemo = objge_StructureGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_StructureGraph.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.Memo); //备注
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.GraphTypeId))
 {
 if (objge_StructureGraphEN.GraphTypeId !=  null)
 {
 var strGraphTypeId = objge_StructureGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGraphTypeId, conge_StructureGraph.GraphTypeId); //图谱类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.GraphTypeId); //图谱类型Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsDisplay))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureGraphEN.IsDisplay == true?"1":"0", conge_StructureGraph.IsDisplay); //是否显示
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsExtend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureGraphEN.IsExtend == true?"1":"0", conge_StructureGraph.IsExtend); //是否扩展
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureGraphEN.IsRecommend == true?"1":"0", conge_StructureGraph.IsRecommend); //是否推荐
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Theme))
 {
 if (objge_StructureGraphEN.Theme !=  null)
 {
 var strTheme = objge_StructureGraphEN.Theme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTheme, conge_StructureGraph.Theme); //主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.Theme); //主题
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureGraphEN.IsSubmit == true?"1":"0", conge_StructureGraph.IsSubmit); //是否提交
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SectionTypeId))
 {
 if (objge_StructureGraphEN.SectionTypeId !=  null)
 {
 var strSectionTypeId = objge_StructureGraphEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionTypeId, conge_StructureGraph.SectionTypeId); //节点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.SectionTypeId); //节点类型Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.TakeUpTime))
 {
 if (objge_StructureGraphEN.TakeUpTime !=  null)
 {
 var strTakeUpTime = objge_StructureGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTakeUpTime, conge_StructureGraph.TakeUpTime); //耗时
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.TakeUpTime); //耗时
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StartTime))
 {
 if (objge_StructureGraphEN.StartTime !=  null)
 {
 var strStartTime = objge_StructureGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartTime, conge_StructureGraph.StartTime); //开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.StartTime); //开始时间
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SubmitTime))
 {
 if (objge_StructureGraphEN.SubmitTime !=  null)
 {
 var strSubmitTime = objge_StructureGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubmitTime, conge_StructureGraph.SubmitTime); //提交时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.SubmitTime); //提交时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StructureGraphId = '{0}'", objge_StructureGraphEN.StructureGraphId); 
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
 /// <param name = "objge_StructureGraphEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_StructureGraphEN objge_StructureGraphEN, string strCondition)
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureGraphEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StructureGraph Set ");
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StructureGraphName))
 {
 if (objge_StructureGraphEN.StructureGraphName !=  null)
 {
 var strStructureGraphName = objge_StructureGraphEN.StructureGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureGraphName = '{0}',", strStructureGraphName); //结构图谱名称
 }
 else
 {
 sbSQL.Append(" StructureGraphName = null,"); //结构图谱名称
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IdCurrEduCls))
 {
 if (objge_StructureGraphEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CourseId))
 {
 if (objge_StructureGraphEN.CourseId !=  null)
 {
 var strCourseId = objge_StructureGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CreateUser))
 {
 if (objge_StructureGraphEN.CreateUser !=  null)
 {
 var strCreateUser = objge_StructureGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUser = '{0}',", strCreateUser); //建立用户
 }
 else
 {
 sbSQL.Append(" CreateUser = null,"); //建立用户
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdDate))
 {
 if (objge_StructureGraphEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StructureGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdUser))
 {
 if (objge_StructureGraphEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StructureGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Memo))
 {
 if (objge_StructureGraphEN.Memo !=  null)
 {
 var strMemo = objge_StructureGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.GraphTypeId))
 {
 if (objge_StructureGraphEN.GraphTypeId !=  null)
 {
 var strGraphTypeId = objge_StructureGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GraphTypeId = '{0}',", strGraphTypeId); //图谱类型Id
 }
 else
 {
 sbSQL.Append(" GraphTypeId = null,"); //图谱类型Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsDisplay))
 {
 sbSQL.AppendFormat(" IsDisplay = '{0}',", objge_StructureGraphEN.IsDisplay == true?"1":"0"); //是否显示
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsExtend))
 {
 sbSQL.AppendFormat(" IsExtend = '{0}',", objge_StructureGraphEN.IsExtend == true?"1":"0"); //是否扩展
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objge_StructureGraphEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Theme))
 {
 if (objge_StructureGraphEN.Theme !=  null)
 {
 var strTheme = objge_StructureGraphEN.Theme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Theme = '{0}',", strTheme); //主题
 }
 else
 {
 sbSQL.Append(" Theme = null,"); //主题
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objge_StructureGraphEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SectionTypeId))
 {
 if (objge_StructureGraphEN.SectionTypeId !=  null)
 {
 var strSectionTypeId = objge_StructureGraphEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionTypeId = '{0}',", strSectionTypeId); //节点类型Id
 }
 else
 {
 sbSQL.Append(" SectionTypeId = null,"); //节点类型Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.TakeUpTime))
 {
 if (objge_StructureGraphEN.TakeUpTime !=  null)
 {
 var strTakeUpTime = objge_StructureGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TakeUpTime = '{0}',", strTakeUpTime); //耗时
 }
 else
 {
 sbSQL.Append(" TakeUpTime = null,"); //耗时
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StartTime))
 {
 if (objge_StructureGraphEN.StartTime !=  null)
 {
 var strStartTime = objge_StructureGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartTime = '{0}',", strStartTime); //开始时间
 }
 else
 {
 sbSQL.Append(" StartTime = null,"); //开始时间
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SubmitTime))
 {
 if (objge_StructureGraphEN.SubmitTime !=  null)
 {
 var strSubmitTime = objge_StructureGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubmitTime = '{0}',", strSubmitTime); //提交时间
 }
 else
 {
 sbSQL.Append(" SubmitTime = null,"); //提交时间
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
 /// <param name = "objge_StructureGraphEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_StructureGraphEN objge_StructureGraphEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureGraphEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StructureGraph Set ");
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StructureGraphName))
 {
 if (objge_StructureGraphEN.StructureGraphName !=  null)
 {
 var strStructureGraphName = objge_StructureGraphEN.StructureGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureGraphName = '{0}',", strStructureGraphName); //结构图谱名称
 }
 else
 {
 sbSQL.Append(" StructureGraphName = null,"); //结构图谱名称
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IdCurrEduCls))
 {
 if (objge_StructureGraphEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CourseId))
 {
 if (objge_StructureGraphEN.CourseId !=  null)
 {
 var strCourseId = objge_StructureGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CreateUser))
 {
 if (objge_StructureGraphEN.CreateUser !=  null)
 {
 var strCreateUser = objge_StructureGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUser = '{0}',", strCreateUser); //建立用户
 }
 else
 {
 sbSQL.Append(" CreateUser = null,"); //建立用户
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdDate))
 {
 if (objge_StructureGraphEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StructureGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdUser))
 {
 if (objge_StructureGraphEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StructureGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Memo))
 {
 if (objge_StructureGraphEN.Memo !=  null)
 {
 var strMemo = objge_StructureGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.GraphTypeId))
 {
 if (objge_StructureGraphEN.GraphTypeId !=  null)
 {
 var strGraphTypeId = objge_StructureGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GraphTypeId = '{0}',", strGraphTypeId); //图谱类型Id
 }
 else
 {
 sbSQL.Append(" GraphTypeId = null,"); //图谱类型Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsDisplay))
 {
 sbSQL.AppendFormat(" IsDisplay = '{0}',", objge_StructureGraphEN.IsDisplay == true?"1":"0"); //是否显示
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsExtend))
 {
 sbSQL.AppendFormat(" IsExtend = '{0}',", objge_StructureGraphEN.IsExtend == true?"1":"0"); //是否扩展
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objge_StructureGraphEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Theme))
 {
 if (objge_StructureGraphEN.Theme !=  null)
 {
 var strTheme = objge_StructureGraphEN.Theme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Theme = '{0}',", strTheme); //主题
 }
 else
 {
 sbSQL.Append(" Theme = null,"); //主题
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objge_StructureGraphEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SectionTypeId))
 {
 if (objge_StructureGraphEN.SectionTypeId !=  null)
 {
 var strSectionTypeId = objge_StructureGraphEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SectionTypeId = '{0}',", strSectionTypeId); //节点类型Id
 }
 else
 {
 sbSQL.Append(" SectionTypeId = null,"); //节点类型Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.TakeUpTime))
 {
 if (objge_StructureGraphEN.TakeUpTime !=  null)
 {
 var strTakeUpTime = objge_StructureGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TakeUpTime = '{0}',", strTakeUpTime); //耗时
 }
 else
 {
 sbSQL.Append(" TakeUpTime = null,"); //耗时
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StartTime))
 {
 if (objge_StructureGraphEN.StartTime !=  null)
 {
 var strStartTime = objge_StructureGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartTime = '{0}',", strStartTime); //开始时间
 }
 else
 {
 sbSQL.Append(" StartTime = null,"); //开始时间
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SubmitTime))
 {
 if (objge_StructureGraphEN.SubmitTime !=  null)
 {
 var strSubmitTime = objge_StructureGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubmitTime = '{0}',", strSubmitTime); //提交时间
 }
 else
 {
 sbSQL.Append(" SubmitTime = null,"); //提交时间
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
 /// <param name = "objge_StructureGraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_StructureGraphEN objge_StructureGraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_StructureGraphEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_StructureGraphEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_StructureGraph Set ");
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StructureGraphName))
 {
 if (objge_StructureGraphEN.StructureGraphName !=  null)
 {
 var strStructureGraphName = objge_StructureGraphEN.StructureGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureGraphName, conge_StructureGraph.StructureGraphName); //结构图谱名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.StructureGraphName); //结构图谱名称
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IdCurrEduCls))
 {
 if (objge_StructureGraphEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_StructureGraphEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conge_StructureGraph.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CourseId))
 {
 if (objge_StructureGraphEN.CourseId !=  null)
 {
 var strCourseId = objge_StructureGraphEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_StructureGraph.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.CourseId); //课程Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.CreateUser))
 {
 if (objge_StructureGraphEN.CreateUser !=  null)
 {
 var strCreateUser = objge_StructureGraphEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUser, conge_StructureGraph.CreateUser); //建立用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.CreateUser); //建立用户
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdDate))
 {
 if (objge_StructureGraphEN.UpdDate !=  null)
 {
 var strUpdDate = objge_StructureGraphEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_StructureGraph.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.UpdDate); //修改日期
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.UpdUser))
 {
 if (objge_StructureGraphEN.UpdUser !=  null)
 {
 var strUpdUser = objge_StructureGraphEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_StructureGraph.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.UpdUser); //修改人
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Memo))
 {
 if (objge_StructureGraphEN.Memo !=  null)
 {
 var strMemo = objge_StructureGraphEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_StructureGraph.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.Memo); //备注
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.GraphTypeId))
 {
 if (objge_StructureGraphEN.GraphTypeId !=  null)
 {
 var strGraphTypeId = objge_StructureGraphEN.GraphTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGraphTypeId, conge_StructureGraph.GraphTypeId); //图谱类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.GraphTypeId); //图谱类型Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsDisplay))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureGraphEN.IsDisplay == true?"1":"0", conge_StructureGraph.IsDisplay); //是否显示
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsExtend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureGraphEN.IsExtend == true?"1":"0", conge_StructureGraph.IsExtend); //是否扩展
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureGraphEN.IsRecommend == true?"1":"0", conge_StructureGraph.IsRecommend); //是否推荐
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.Theme))
 {
 if (objge_StructureGraphEN.Theme !=  null)
 {
 var strTheme = objge_StructureGraphEN.Theme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTheme, conge_StructureGraph.Theme); //主题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.Theme); //主题
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_StructureGraphEN.IsSubmit == true?"1":"0", conge_StructureGraph.IsSubmit); //是否提交
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SectionTypeId))
 {
 if (objge_StructureGraphEN.SectionTypeId !=  null)
 {
 var strSectionTypeId = objge_StructureGraphEN.SectionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSectionTypeId, conge_StructureGraph.SectionTypeId); //节点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.SectionTypeId); //节点类型Id
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.TakeUpTime))
 {
 if (objge_StructureGraphEN.TakeUpTime !=  null)
 {
 var strTakeUpTime = objge_StructureGraphEN.TakeUpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTakeUpTime, conge_StructureGraph.TakeUpTime); //耗时
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.TakeUpTime); //耗时
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.StartTime))
 {
 if (objge_StructureGraphEN.StartTime !=  null)
 {
 var strStartTime = objge_StructureGraphEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartTime, conge_StructureGraph.StartTime); //开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.StartTime); //开始时间
 }
 }
 
 if (objge_StructureGraphEN.IsUpdated(conge_StructureGraph.SubmitTime))
 {
 if (objge_StructureGraphEN.SubmitTime !=  null)
 {
 var strSubmitTime = objge_StructureGraphEN.SubmitTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubmitTime, conge_StructureGraph.SubmitTime); //提交时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_StructureGraph.SubmitTime); //提交时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StructureGraphId = '{0}'", objge_StructureGraphEN.StructureGraphId); 
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
 /// <param name = "strStructureGraphId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strStructureGraphId) 
{
CheckPrimaryKey(strStructureGraphId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strStructureGraphId,
};
 objSQL.ExecSP("ge_StructureGraph_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strStructureGraphId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strStructureGraphId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strStructureGraphId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
//删除ge_StructureGraph本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StructureGraph where StructureGraphId = " + "'"+ strStructureGraphId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_StructureGraph(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
//删除ge_StructureGraph本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StructureGraph where StructureGraphId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strStructureGraphId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strStructureGraphId) 
{
CheckPrimaryKey(strStructureGraphId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
//删除ge_StructureGraph本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_StructureGraph where StructureGraphId = " + "'"+ strStructureGraphId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_StructureGraph(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: Delge_StructureGraph)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_StructureGraph where " + strCondition ;
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
public bool Delge_StructureGraphWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_StructureGraphDA: Delge_StructureGraphWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_StructureGraph where " + strCondition ;
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
 /// <param name = "objge_StructureGraphENS">源对象</param>
 /// <param name = "objge_StructureGraphENT">目标对象</param>
public void CopyTo(clsge_StructureGraphEN objge_StructureGraphENS, clsge_StructureGraphEN objge_StructureGraphENT)
{
objge_StructureGraphENT.StructureGraphId = objge_StructureGraphENS.StructureGraphId; //知识图谱Id
objge_StructureGraphENT.StructureGraphName = objge_StructureGraphENS.StructureGraphName; //结构图谱名称
objge_StructureGraphENT.IdCurrEduCls = objge_StructureGraphENS.IdCurrEduCls; //教学班流水号
objge_StructureGraphENT.CourseId = objge_StructureGraphENS.CourseId; //课程Id
objge_StructureGraphENT.CreateUser = objge_StructureGraphENS.CreateUser; //建立用户
objge_StructureGraphENT.UpdDate = objge_StructureGraphENS.UpdDate; //修改日期
objge_StructureGraphENT.UpdUser = objge_StructureGraphENS.UpdUser; //修改人
objge_StructureGraphENT.Memo = objge_StructureGraphENS.Memo; //备注
objge_StructureGraphENT.GraphTypeId = objge_StructureGraphENS.GraphTypeId; //图谱类型Id
objge_StructureGraphENT.IsDisplay = objge_StructureGraphENS.IsDisplay; //是否显示
objge_StructureGraphENT.IsExtend = objge_StructureGraphENS.IsExtend; //是否扩展
objge_StructureGraphENT.IsRecommend = objge_StructureGraphENS.IsRecommend; //是否推荐
objge_StructureGraphENT.Theme = objge_StructureGraphENS.Theme; //主题
objge_StructureGraphENT.IsSubmit = objge_StructureGraphENS.IsSubmit; //是否提交
objge_StructureGraphENT.SectionTypeId = objge_StructureGraphENS.SectionTypeId; //节点类型Id
objge_StructureGraphENT.TakeUpTime = objge_StructureGraphENS.TakeUpTime; //耗时
objge_StructureGraphENT.StartTime = objge_StructureGraphENS.StartTime; //开始时间
objge_StructureGraphENT.SubmitTime = objge_StructureGraphENS.SubmitTime; //提交时间
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_StructureGraphEN objge_StructureGraphEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_StructureGraphEN.SectionTypeId, conge_StructureGraph.SectionTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.StructureGraphId, 10, conge_StructureGraph.StructureGraphId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.StructureGraphName, 100, conge_StructureGraph.StructureGraphName);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.IdCurrEduCls, 8, conge_StructureGraph.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.CourseId, 8, conge_StructureGraph.CourseId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.CreateUser, 50, conge_StructureGraph.CreateUser);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.UpdDate, 20, conge_StructureGraph.UpdDate);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.UpdUser, 20, conge_StructureGraph.UpdUser);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.Memo, 1000, conge_StructureGraph.Memo);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.GraphTypeId, 2, conge_StructureGraph.GraphTypeId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.Theme, 100, conge_StructureGraph.Theme);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.SectionTypeId, 8, conge_StructureGraph.SectionTypeId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.TakeUpTime, 50, conge_StructureGraph.TakeUpTime);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.StartTime, 20, conge_StructureGraph.StartTime);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.SubmitTime, 20, conge_StructureGraph.SubmitTime);
//检查字段外键固定长度
 objge_StructureGraphEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_StructureGraphEN objge_StructureGraphEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.StructureGraphName, 100, conge_StructureGraph.StructureGraphName);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.IdCurrEduCls, 8, conge_StructureGraph.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.CourseId, 8, conge_StructureGraph.CourseId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.CreateUser, 50, conge_StructureGraph.CreateUser);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.UpdDate, 20, conge_StructureGraph.UpdDate);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.UpdUser, 20, conge_StructureGraph.UpdUser);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.Memo, 1000, conge_StructureGraph.Memo);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.GraphTypeId, 2, conge_StructureGraph.GraphTypeId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.Theme, 100, conge_StructureGraph.Theme);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.SectionTypeId, 8, conge_StructureGraph.SectionTypeId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.TakeUpTime, 50, conge_StructureGraph.TakeUpTime);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.StartTime, 20, conge_StructureGraph.StartTime);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.SubmitTime, 20, conge_StructureGraph.SubmitTime);
//检查外键字段长度
 objge_StructureGraphEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_StructureGraphEN objge_StructureGraphEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.StructureGraphId, 10, conge_StructureGraph.StructureGraphId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.StructureGraphName, 100, conge_StructureGraph.StructureGraphName);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.IdCurrEduCls, 8, conge_StructureGraph.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.CourseId, 8, conge_StructureGraph.CourseId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.CreateUser, 50, conge_StructureGraph.CreateUser);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.UpdDate, 20, conge_StructureGraph.UpdDate);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.UpdUser, 20, conge_StructureGraph.UpdUser);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.Memo, 1000, conge_StructureGraph.Memo);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.GraphTypeId, 2, conge_StructureGraph.GraphTypeId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.Theme, 100, conge_StructureGraph.Theme);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.SectionTypeId, 8, conge_StructureGraph.SectionTypeId);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.TakeUpTime, 50, conge_StructureGraph.TakeUpTime);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.StartTime, 20, conge_StructureGraph.StartTime);
clsCheckSql.CheckFieldLen(objge_StructureGraphEN.SubmitTime, 20, conge_StructureGraph.SubmitTime);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.StructureGraphId, conge_StructureGraph.StructureGraphId);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.StructureGraphName, conge_StructureGraph.StructureGraphName);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.IdCurrEduCls, conge_StructureGraph.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.CourseId, conge_StructureGraph.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.CreateUser, conge_StructureGraph.CreateUser);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.UpdDate, conge_StructureGraph.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.UpdUser, conge_StructureGraph.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.Memo, conge_StructureGraph.Memo);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.GraphTypeId, conge_StructureGraph.GraphTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.Theme, conge_StructureGraph.Theme);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.SectionTypeId, conge_StructureGraph.SectionTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.TakeUpTime, conge_StructureGraph.TakeUpTime);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.StartTime, conge_StructureGraph.StartTime);
clsCheckSql.CheckSqlInjection4Field(objge_StructureGraphEN.SubmitTime, conge_StructureGraph.SubmitTime);
//检查外键字段长度
 objge_StructureGraphEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetStructureGraphId()
{
//获取某学院所有专业信息
string strSQL = "select StructureGraphId, StructureGraphName from ge_StructureGraph ";
 clsSpecSQLforSql mySql = clsge_StructureGraphDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_StructureGraph(结构图谱表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StructureGraphEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_StructureGraphEN objge_StructureGraphEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StructureGraphId = '{0}'", objge_StructureGraphEN.StructureGraphId);
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
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_StructureGraphEN._CurrTabName);
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
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_StructureGraphEN._CurrTabName, strCondition);
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
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
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
 objSQL = clsge_StructureGraphDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}