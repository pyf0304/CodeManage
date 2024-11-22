
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_QuestionStructureGraphRelaDA
 表名:ge_QuestionStructureGraphRela(01120906)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:14
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
 /// 问题结构图关系(ge_QuestionStructureGraphRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_QuestionStructureGraphRelaDA : clsCommBase4DA
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
 return clsge_QuestionStructureGraphRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_QuestionStructureGraphRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_QuestionStructureGraphRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_QuestionStructureGraphRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_QuestionStructureGraphRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_QuestionStructureGraphRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTable_ge_QuestionStructureGraphRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_QuestionStructureGraphRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_QuestionStructureGraphRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_QuestionStructureGraphRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_QuestionStructureGraphRela.* from ge_QuestionStructureGraphRela Left Join {1} on {2} where {3} and ge_QuestionStructureGraphRela.mId not in (Select top {5} ge_QuestionStructureGraphRela.mId from ge_QuestionStructureGraphRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_QuestionStructureGraphRela where {1} and mId not in (Select top {2} mId from ge_QuestionStructureGraphRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_QuestionStructureGraphRela where {1} and mId not in (Select top {3} mId from ge_QuestionStructureGraphRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_QuestionStructureGraphRela.* from ge_QuestionStructureGraphRela Left Join {1} on {2} where {3} and ge_QuestionStructureGraphRela.mId not in (Select top {5} ge_QuestionStructureGraphRela.mId from ge_QuestionStructureGraphRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_QuestionStructureGraphRela where {1} and mId not in (Select top {2} mId from ge_QuestionStructureGraphRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_QuestionStructureGraphRela where {1} and mId not in (Select top {3} mId from ge_QuestionStructureGraphRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_QuestionStructureGraphRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA:GetObjLst)", objException.Message));
}
List<clsge_QuestionStructureGraphRelaEN> arrObjLst = new List<clsge_QuestionStructureGraphRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN = new clsge_QuestionStructureGraphRelaEN();
try
{
objge_QuestionStructureGraphRelaEN.mId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.mId].ToString().Trim()); //mId
objge_QuestionStructureGraphRelaEN.QuestionId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.QuestionId].ToString().Trim()); //题目Id
objge_QuestionStructureGraphRelaEN.StructureGraphId = objRow[conge_QuestionStructureGraphRela.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_QuestionStructureGraphRelaEN.CourseId = objRow[conge_QuestionStructureGraphRela.CourseId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CourseId].ToString().Trim(); //课程Id
objge_QuestionStructureGraphRelaEN.CreateUser = objRow[conge_QuestionStructureGraphRela.CreateUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CreateUser].ToString().Trim(); //建立用户
objge_QuestionStructureGraphRelaEN.UpdDate = objRow[conge_QuestionStructureGraphRela.UpdDate] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdDate].ToString().Trim(); //修改日期
objge_QuestionStructureGraphRelaEN.UpdUser = objRow[conge_QuestionStructureGraphRela.UpdUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdUser].ToString().Trim(); //修改人
objge_QuestionStructureGraphRelaEN.Memo = objRow[conge_QuestionStructureGraphRela.Memo] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.Memo].ToString().Trim(); //备注
objge_QuestionStructureGraphRelaEN.GameLevelId = objRow[conge_QuestionStructureGraphRela.GameLevelId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.GameLevelId].ToString().Trim(); //游戏关卡Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetObjLst)", objException.Message));
}
objge_QuestionStructureGraphRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_QuestionStructureGraphRelaEN);
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
public List<clsge_QuestionStructureGraphRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_QuestionStructureGraphRelaEN> arrObjLst = new List<clsge_QuestionStructureGraphRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN = new clsge_QuestionStructureGraphRelaEN();
try
{
objge_QuestionStructureGraphRelaEN.mId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.mId].ToString().Trim()); //mId
objge_QuestionStructureGraphRelaEN.QuestionId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.QuestionId].ToString().Trim()); //题目Id
objge_QuestionStructureGraphRelaEN.StructureGraphId = objRow[conge_QuestionStructureGraphRela.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_QuestionStructureGraphRelaEN.CourseId = objRow[conge_QuestionStructureGraphRela.CourseId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CourseId].ToString().Trim(); //课程Id
objge_QuestionStructureGraphRelaEN.CreateUser = objRow[conge_QuestionStructureGraphRela.CreateUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CreateUser].ToString().Trim(); //建立用户
objge_QuestionStructureGraphRelaEN.UpdDate = objRow[conge_QuestionStructureGraphRela.UpdDate] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdDate].ToString().Trim(); //修改日期
objge_QuestionStructureGraphRelaEN.UpdUser = objRow[conge_QuestionStructureGraphRela.UpdUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdUser].ToString().Trim(); //修改人
objge_QuestionStructureGraphRelaEN.Memo = objRow[conge_QuestionStructureGraphRela.Memo] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.Memo].ToString().Trim(); //备注
objge_QuestionStructureGraphRelaEN.GameLevelId = objRow[conge_QuestionStructureGraphRela.GameLevelId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.GameLevelId].ToString().Trim(); //游戏关卡Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetObjLst)", objException.Message));
}
objge_QuestionStructureGraphRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_QuestionStructureGraphRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_QuestionStructureGraphRela(ref clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where mId = " + ""+ objge_QuestionStructureGraphRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_QuestionStructureGraphRelaEN.mId = TransNullToInt(objDT.Rows[0][conge_QuestionStructureGraphRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objge_QuestionStructureGraphRelaEN.QuestionId = TransNullToInt(objDT.Rows[0][conge_QuestionStructureGraphRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_QuestionStructureGraphRelaEN.StructureGraphId = objDT.Rows[0][conge_QuestionStructureGraphRela.StructureGraphId].ToString().Trim(); //知识图谱Id(字段类型:char,字段长度:10,是否可空:True)
 objge_QuestionStructureGraphRelaEN.CourseId = objDT.Rows[0][conge_QuestionStructureGraphRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_QuestionStructureGraphRelaEN.CreateUser = objDT.Rows[0][conge_QuestionStructureGraphRela.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objge_QuestionStructureGraphRelaEN.UpdDate = objDT.Rows[0][conge_QuestionStructureGraphRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_QuestionStructureGraphRelaEN.UpdUser = objDT.Rows[0][conge_QuestionStructureGraphRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_QuestionStructureGraphRelaEN.Memo = objDT.Rows[0][conge_QuestionStructureGraphRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_QuestionStructureGraphRelaEN.GameLevelId = objDT.Rows[0][conge_QuestionStructureGraphRela.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_QuestionStructureGraphRelaDA: Getge_QuestionStructureGraphRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_QuestionStructureGraphRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN = new clsge_QuestionStructureGraphRelaEN();
try
{
 objge_QuestionStructureGraphRelaEN.mId = Int32.Parse(objRow[conge_QuestionStructureGraphRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objge_QuestionStructureGraphRelaEN.QuestionId = Int32.Parse(objRow[conge_QuestionStructureGraphRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objge_QuestionStructureGraphRelaEN.StructureGraphId = objRow[conge_QuestionStructureGraphRela.StructureGraphId].ToString().Trim(); //知识图谱Id(字段类型:char,字段长度:10,是否可空:True)
 objge_QuestionStructureGraphRelaEN.CourseId = objRow[conge_QuestionStructureGraphRela.CourseId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_QuestionStructureGraphRelaEN.CreateUser = objRow[conge_QuestionStructureGraphRela.CreateUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CreateUser].ToString().Trim(); //建立用户(字段类型:varchar,字段长度:50,是否可空:True)
 objge_QuestionStructureGraphRelaEN.UpdDate = objRow[conge_QuestionStructureGraphRela.UpdDate] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_QuestionStructureGraphRelaEN.UpdUser = objRow[conge_QuestionStructureGraphRela.UpdUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_QuestionStructureGraphRelaEN.Memo = objRow[conge_QuestionStructureGraphRela.Memo] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_QuestionStructureGraphRelaEN.GameLevelId = objRow[conge_QuestionStructureGraphRela.GameLevelId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetObjBymId)", objException.Message));
}
return objge_QuestionStructureGraphRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_QuestionStructureGraphRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN = new clsge_QuestionStructureGraphRelaEN()
{
mId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.mId].ToString().Trim()), //mId
QuestionId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.QuestionId].ToString().Trim()), //题目Id
StructureGraphId = objRow[conge_QuestionStructureGraphRela.StructureGraphId].ToString().Trim(), //知识图谱Id
CourseId = objRow[conge_QuestionStructureGraphRela.CourseId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CourseId].ToString().Trim(), //课程Id
CreateUser = objRow[conge_QuestionStructureGraphRela.CreateUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CreateUser].ToString().Trim(), //建立用户
UpdDate = objRow[conge_QuestionStructureGraphRela.UpdDate] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_QuestionStructureGraphRela.UpdUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_QuestionStructureGraphRela.Memo] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.Memo].ToString().Trim(), //备注
GameLevelId = objRow[conge_QuestionStructureGraphRela.GameLevelId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.GameLevelId].ToString().Trim() //游戏关卡Id
};
objge_QuestionStructureGraphRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_QuestionStructureGraphRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_QuestionStructureGraphRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN = new clsge_QuestionStructureGraphRelaEN();
try
{
objge_QuestionStructureGraphRelaEN.mId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.mId].ToString().Trim()); //mId
objge_QuestionStructureGraphRelaEN.QuestionId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.QuestionId].ToString().Trim()); //题目Id
objge_QuestionStructureGraphRelaEN.StructureGraphId = objRow[conge_QuestionStructureGraphRela.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_QuestionStructureGraphRelaEN.CourseId = objRow[conge_QuestionStructureGraphRela.CourseId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CourseId].ToString().Trim(); //课程Id
objge_QuestionStructureGraphRelaEN.CreateUser = objRow[conge_QuestionStructureGraphRela.CreateUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CreateUser].ToString().Trim(); //建立用户
objge_QuestionStructureGraphRelaEN.UpdDate = objRow[conge_QuestionStructureGraphRela.UpdDate] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdDate].ToString().Trim(); //修改日期
objge_QuestionStructureGraphRelaEN.UpdUser = objRow[conge_QuestionStructureGraphRela.UpdUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdUser].ToString().Trim(); //修改人
objge_QuestionStructureGraphRelaEN.Memo = objRow[conge_QuestionStructureGraphRela.Memo] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.Memo].ToString().Trim(); //备注
objge_QuestionStructureGraphRelaEN.GameLevelId = objRow[conge_QuestionStructureGraphRela.GameLevelId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.GameLevelId].ToString().Trim(); //游戏关卡Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetObjByDataRowge_QuestionStructureGraphRela)", objException.Message));
}
objge_QuestionStructureGraphRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_QuestionStructureGraphRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_QuestionStructureGraphRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN = new clsge_QuestionStructureGraphRelaEN();
try
{
objge_QuestionStructureGraphRelaEN.mId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.mId].ToString().Trim()); //mId
objge_QuestionStructureGraphRelaEN.QuestionId = TransNullToInt(objRow[conge_QuestionStructureGraphRela.QuestionId].ToString().Trim()); //题目Id
objge_QuestionStructureGraphRelaEN.StructureGraphId = objRow[conge_QuestionStructureGraphRela.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_QuestionStructureGraphRelaEN.CourseId = objRow[conge_QuestionStructureGraphRela.CourseId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CourseId].ToString().Trim(); //课程Id
objge_QuestionStructureGraphRelaEN.CreateUser = objRow[conge_QuestionStructureGraphRela.CreateUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.CreateUser].ToString().Trim(); //建立用户
objge_QuestionStructureGraphRelaEN.UpdDate = objRow[conge_QuestionStructureGraphRela.UpdDate] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdDate].ToString().Trim(); //修改日期
objge_QuestionStructureGraphRelaEN.UpdUser = objRow[conge_QuestionStructureGraphRela.UpdUser] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.UpdUser].ToString().Trim(); //修改人
objge_QuestionStructureGraphRelaEN.Memo = objRow[conge_QuestionStructureGraphRela.Memo] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.Memo].ToString().Trim(); //备注
objge_QuestionStructureGraphRelaEN.GameLevelId = objRow[conge_QuestionStructureGraphRela.GameLevelId] == DBNull.Value ? null : objRow[conge_QuestionStructureGraphRela.GameLevelId].ToString().Trim(); //游戏关卡Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_QuestionStructureGraphRelaDA: GetObjByDataRow)", objException.Message));
}
objge_QuestionStructureGraphRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_QuestionStructureGraphRelaEN;
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
objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_QuestionStructureGraphRelaEN._CurrTabName, conge_QuestionStructureGraphRela.mId, 8, "");
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
objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_QuestionStructureGraphRelaEN._CurrTabName, conge_QuestionStructureGraphRela.mId, 8, strPrefix);
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ge_QuestionStructureGraphRela where " + strCondition;
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ge_QuestionStructureGraphRela where " + strCondition;
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_QuestionStructureGraphRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_QuestionStructureGraphRela", strCondition))
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
objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_QuestionStructureGraphRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
 {
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_QuestionStructureGraphRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_QuestionStructureGraphRela");
objRow = objDS.Tables["ge_QuestionStructureGraphRela"].NewRow();
objRow[conge_QuestionStructureGraphRela.QuestionId] = objge_QuestionStructureGraphRelaEN.QuestionId; //题目Id
objRow[conge_QuestionStructureGraphRela.StructureGraphId] = objge_QuestionStructureGraphRelaEN.StructureGraphId; //知识图谱Id
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  "")
 {
objRow[conge_QuestionStructureGraphRela.CourseId] = objge_QuestionStructureGraphRelaEN.CourseId; //课程Id
 }
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  "")
 {
objRow[conge_QuestionStructureGraphRela.CreateUser] = objge_QuestionStructureGraphRelaEN.CreateUser; //建立用户
 }
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  "")
 {
objRow[conge_QuestionStructureGraphRela.UpdDate] = objge_QuestionStructureGraphRelaEN.UpdDate; //修改日期
 }
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  "")
 {
objRow[conge_QuestionStructureGraphRela.UpdUser] = objge_QuestionStructureGraphRelaEN.UpdUser; //修改人
 }
 if (objge_QuestionStructureGraphRelaEN.Memo !=  "")
 {
objRow[conge_QuestionStructureGraphRela.Memo] = objge_QuestionStructureGraphRelaEN.Memo; //备注
 }
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  "")
 {
objRow[conge_QuestionStructureGraphRela.GameLevelId] = objge_QuestionStructureGraphRelaEN.GameLevelId; //游戏关卡Id
 }
objDS.Tables[clsge_QuestionStructureGraphRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_QuestionStructureGraphRelaEN._CurrTabName);
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
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_QuestionStructureGraphRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.QuestionId);
 arrValueListForInsert.Add(objge_QuestionStructureGraphRelaEN.QuestionId.ToString());
 
 if (objge_QuestionStructureGraphRelaEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.StructureGraphId);
 var strStructureGraphId = objge_QuestionStructureGraphRelaEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.CourseId);
 var strCourseId = objge_QuestionStructureGraphRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.CreateUser);
 var strCreateUser = objge_QuestionStructureGraphRelaEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.UpdDate);
 var strUpdDate = objge_QuestionStructureGraphRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.UpdUser);
 var strUpdUser = objge_QuestionStructureGraphRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.Memo);
 var strMemo = objge_QuestionStructureGraphRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.GameLevelId);
 var strGameLevelId = objge_QuestionStructureGraphRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_QuestionStructureGraphRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_QuestionStructureGraphRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.QuestionId);
 arrValueListForInsert.Add(objge_QuestionStructureGraphRelaEN.QuestionId.ToString());
 
 if (objge_QuestionStructureGraphRelaEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.StructureGraphId);
 var strStructureGraphId = objge_QuestionStructureGraphRelaEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.CourseId);
 var strCourseId = objge_QuestionStructureGraphRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.CreateUser);
 var strCreateUser = objge_QuestionStructureGraphRelaEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.UpdDate);
 var strUpdDate = objge_QuestionStructureGraphRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.UpdUser);
 var strUpdUser = objge_QuestionStructureGraphRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.Memo);
 var strMemo = objge_QuestionStructureGraphRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.GameLevelId);
 var strGameLevelId = objge_QuestionStructureGraphRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_QuestionStructureGraphRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_QuestionStructureGraphRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.QuestionId);
 arrValueListForInsert.Add(objge_QuestionStructureGraphRelaEN.QuestionId.ToString());
 
 if (objge_QuestionStructureGraphRelaEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.StructureGraphId);
 var strStructureGraphId = objge_QuestionStructureGraphRelaEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.CourseId);
 var strCourseId = objge_QuestionStructureGraphRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.CreateUser);
 var strCreateUser = objge_QuestionStructureGraphRelaEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.UpdDate);
 var strUpdDate = objge_QuestionStructureGraphRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.UpdUser);
 var strUpdUser = objge_QuestionStructureGraphRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.Memo);
 var strMemo = objge_QuestionStructureGraphRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.GameLevelId);
 var strGameLevelId = objge_QuestionStructureGraphRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_QuestionStructureGraphRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_QuestionStructureGraphRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.QuestionId);
 arrValueListForInsert.Add(objge_QuestionStructureGraphRelaEN.QuestionId.ToString());
 
 if (objge_QuestionStructureGraphRelaEN.StructureGraphId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.StructureGraphId);
 var strStructureGraphId = objge_QuestionStructureGraphRelaEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStructureGraphId + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.CourseId);
 var strCourseId = objge_QuestionStructureGraphRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.CreateUser);
 var strCreateUser = objge_QuestionStructureGraphRelaEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateUser + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.UpdDate);
 var strUpdDate = objge_QuestionStructureGraphRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.UpdUser);
 var strUpdUser = objge_QuestionStructureGraphRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.Memo);
 var strMemo = objge_QuestionStructureGraphRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_QuestionStructureGraphRela.GameLevelId);
 var strGameLevelId = objge_QuestionStructureGraphRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_QuestionStructureGraphRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_QuestionStructureGraphRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_QuestionStructureGraphRela");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_QuestionStructureGraphRelaEN._CurrTabName ].NewRow();
objRow[conge_QuestionStructureGraphRela.QuestionId] = oRow[conge_QuestionStructureGraphRela.QuestionId].ToString().Trim(); //题目Id
objRow[conge_QuestionStructureGraphRela.StructureGraphId] = oRow[conge_QuestionStructureGraphRela.StructureGraphId].ToString().Trim(); //知识图谱Id
objRow[conge_QuestionStructureGraphRela.CourseId] = oRow[conge_QuestionStructureGraphRela.CourseId].ToString().Trim(); //课程Id
objRow[conge_QuestionStructureGraphRela.CreateUser] = oRow[conge_QuestionStructureGraphRela.CreateUser].ToString().Trim(); //建立用户
objRow[conge_QuestionStructureGraphRela.UpdDate] = oRow[conge_QuestionStructureGraphRela.UpdDate].ToString().Trim(); //修改日期
objRow[conge_QuestionStructureGraphRela.UpdUser] = oRow[conge_QuestionStructureGraphRela.UpdUser].ToString().Trim(); //修改人
objRow[conge_QuestionStructureGraphRela.Memo] = oRow[conge_QuestionStructureGraphRela.Memo].ToString().Trim(); //备注
objRow[conge_QuestionStructureGraphRela.GameLevelId] = oRow[conge_QuestionStructureGraphRela.GameLevelId].ToString().Trim(); //游戏关卡Id
 objDS.Tables[clsge_QuestionStructureGraphRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_QuestionStructureGraphRelaEN._CurrTabName);
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
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_QuestionStructureGraphRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
strSQL = "Select * from ge_QuestionStructureGraphRela where mId = " + ""+ objge_QuestionStructureGraphRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_QuestionStructureGraphRelaEN._CurrTabName);
if (objDS.Tables[clsge_QuestionStructureGraphRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objge_QuestionStructureGraphRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsge_QuestionStructureGraphRelaEN._CurrTabName].Rows[0];
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.QuestionId))
 {
objRow[conge_QuestionStructureGraphRela.QuestionId] = objge_QuestionStructureGraphRelaEN.QuestionId; //题目Id
 }
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.StructureGraphId))
 {
objRow[conge_QuestionStructureGraphRela.StructureGraphId] = objge_QuestionStructureGraphRelaEN.StructureGraphId; //知识图谱Id
 }
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CourseId))
 {
objRow[conge_QuestionStructureGraphRela.CourseId] = objge_QuestionStructureGraphRelaEN.CourseId; //课程Id
 }
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CreateUser))
 {
objRow[conge_QuestionStructureGraphRela.CreateUser] = objge_QuestionStructureGraphRelaEN.CreateUser; //建立用户
 }
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdDate))
 {
objRow[conge_QuestionStructureGraphRela.UpdDate] = objge_QuestionStructureGraphRelaEN.UpdDate; //修改日期
 }
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdUser))
 {
objRow[conge_QuestionStructureGraphRela.UpdUser] = objge_QuestionStructureGraphRelaEN.UpdUser; //修改人
 }
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.Memo))
 {
objRow[conge_QuestionStructureGraphRela.Memo] = objge_QuestionStructureGraphRelaEN.Memo; //备注
 }
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.GameLevelId))
 {
objRow[conge_QuestionStructureGraphRela.GameLevelId] = objge_QuestionStructureGraphRelaEN.GameLevelId; //游戏关卡Id
 }
try
{
objDA.Update(objDS, clsge_QuestionStructureGraphRelaEN._CurrTabName);
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
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_QuestionStructureGraphRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_QuestionStructureGraphRela Set ");
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_QuestionStructureGraphRelaEN.QuestionId, conge_QuestionStructureGraphRela.QuestionId); //题目Id
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.StructureGraphId))
 {
 if (objge_QuestionStructureGraphRelaEN.StructureGraphId !=  null)
 {
 var strStructureGraphId = objge_QuestionStructureGraphRelaEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureGraphId, conge_QuestionStructureGraphRela.StructureGraphId); //知识图谱Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.StructureGraphId); //知识图谱Id
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CourseId))
 {
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  null)
 {
 var strCourseId = objge_QuestionStructureGraphRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_QuestionStructureGraphRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.CourseId); //课程Id
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CreateUser))
 {
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  null)
 {
 var strCreateUser = objge_QuestionStructureGraphRelaEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUser, conge_QuestionStructureGraphRela.CreateUser); //建立用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.CreateUser); //建立用户
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdDate))
 {
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_QuestionStructureGraphRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_QuestionStructureGraphRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.UpdDate); //修改日期
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdUser))
 {
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objge_QuestionStructureGraphRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_QuestionStructureGraphRela.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.UpdUser); //修改人
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.Memo))
 {
 if (objge_QuestionStructureGraphRelaEN.Memo !=  null)
 {
 var strMemo = objge_QuestionStructureGraphRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_QuestionStructureGraphRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.Memo); //备注
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.GameLevelId))
 {
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_QuestionStructureGraphRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGameLevelId, conge_QuestionStructureGraphRela.GameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.GameLevelId); //游戏关卡Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objge_QuestionStructureGraphRelaEN.mId); 
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
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN, string strCondition)
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_QuestionStructureGraphRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_QuestionStructureGraphRela Set ");
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_QuestionStructureGraphRelaEN.QuestionId); //题目Id
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.StructureGraphId))
 {
 if (objge_QuestionStructureGraphRelaEN.StructureGraphId !=  null)
 {
 var strStructureGraphId = objge_QuestionStructureGraphRelaEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureGraphId = '{0}',", strStructureGraphId); //知识图谱Id
 }
 else
 {
 sbSQL.Append(" StructureGraphId = null,"); //知识图谱Id
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CourseId))
 {
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  null)
 {
 var strCourseId = objge_QuestionStructureGraphRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CreateUser))
 {
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  null)
 {
 var strCreateUser = objge_QuestionStructureGraphRelaEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUser = '{0}',", strCreateUser); //建立用户
 }
 else
 {
 sbSQL.Append(" CreateUser = null,"); //建立用户
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdDate))
 {
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_QuestionStructureGraphRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdUser))
 {
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objge_QuestionStructureGraphRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.Memo))
 {
 if (objge_QuestionStructureGraphRelaEN.Memo !=  null)
 {
 var strMemo = objge_QuestionStructureGraphRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.GameLevelId))
 {
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_QuestionStructureGraphRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GameLevelId = '{0}',", strGameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.Append(" GameLevelId = null,"); //游戏关卡Id
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
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_QuestionStructureGraphRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_QuestionStructureGraphRela Set ");
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objge_QuestionStructureGraphRelaEN.QuestionId); //题目Id
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.StructureGraphId))
 {
 if (objge_QuestionStructureGraphRelaEN.StructureGraphId !=  null)
 {
 var strStructureGraphId = objge_QuestionStructureGraphRelaEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StructureGraphId = '{0}',", strStructureGraphId); //知识图谱Id
 }
 else
 {
 sbSQL.Append(" StructureGraphId = null,"); //知识图谱Id
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CourseId))
 {
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  null)
 {
 var strCourseId = objge_QuestionStructureGraphRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CreateUser))
 {
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  null)
 {
 var strCreateUser = objge_QuestionStructureGraphRelaEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateUser = '{0}',", strCreateUser); //建立用户
 }
 else
 {
 sbSQL.Append(" CreateUser = null,"); //建立用户
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdDate))
 {
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_QuestionStructureGraphRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdUser))
 {
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objge_QuestionStructureGraphRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.Memo))
 {
 if (objge_QuestionStructureGraphRelaEN.Memo !=  null)
 {
 var strMemo = objge_QuestionStructureGraphRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.GameLevelId))
 {
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_QuestionStructureGraphRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GameLevelId = '{0}',", strGameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.Append(" GameLevelId = null,"); //游戏关卡Id
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
 /// <param name = "objge_QuestionStructureGraphRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_QuestionStructureGraphRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_QuestionStructureGraphRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_QuestionStructureGraphRela Set ");
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objge_QuestionStructureGraphRelaEN.QuestionId, conge_QuestionStructureGraphRela.QuestionId); //题目Id
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.StructureGraphId))
 {
 if (objge_QuestionStructureGraphRelaEN.StructureGraphId !=  null)
 {
 var strStructureGraphId = objge_QuestionStructureGraphRelaEN.StructureGraphId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStructureGraphId, conge_QuestionStructureGraphRela.StructureGraphId); //知识图谱Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.StructureGraphId); //知识图谱Id
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CourseId))
 {
 if (objge_QuestionStructureGraphRelaEN.CourseId !=  null)
 {
 var strCourseId = objge_QuestionStructureGraphRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_QuestionStructureGraphRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.CourseId); //课程Id
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.CreateUser))
 {
 if (objge_QuestionStructureGraphRelaEN.CreateUser !=  null)
 {
 var strCreateUser = objge_QuestionStructureGraphRelaEN.CreateUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateUser, conge_QuestionStructureGraphRela.CreateUser); //建立用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.CreateUser); //建立用户
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdDate))
 {
 if (objge_QuestionStructureGraphRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objge_QuestionStructureGraphRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_QuestionStructureGraphRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.UpdDate); //修改日期
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.UpdUser))
 {
 if (objge_QuestionStructureGraphRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objge_QuestionStructureGraphRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_QuestionStructureGraphRela.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.UpdUser); //修改人
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.Memo))
 {
 if (objge_QuestionStructureGraphRelaEN.Memo !=  null)
 {
 var strMemo = objge_QuestionStructureGraphRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_QuestionStructureGraphRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.Memo); //备注
 }
 }
 
 if (objge_QuestionStructureGraphRelaEN.IsUpdated(conge_QuestionStructureGraphRela.GameLevelId))
 {
 if (objge_QuestionStructureGraphRelaEN.GameLevelId !=  null)
 {
 var strGameLevelId = objge_QuestionStructureGraphRelaEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGameLevelId, conge_QuestionStructureGraphRela.GameLevelId); //游戏关卡Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_QuestionStructureGraphRela.GameLevelId); //游戏关卡Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objge_QuestionStructureGraphRelaEN.mId); 
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ge_QuestionStructureGraphRela_Delete", values);
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
//删除ge_QuestionStructureGraphRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_QuestionStructureGraphRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_QuestionStructureGraphRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
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
//删除ge_QuestionStructureGraphRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_QuestionStructureGraphRela where mId in (" + strKeyList + ")";
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
//删除ge_QuestionStructureGraphRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_QuestionStructureGraphRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_QuestionStructureGraphRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: Delge_QuestionStructureGraphRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_QuestionStructureGraphRela where " + strCondition ;
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
public bool Delge_QuestionStructureGraphRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_QuestionStructureGraphRelaDA: Delge_QuestionStructureGraphRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_QuestionStructureGraphRela where " + strCondition ;
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
 /// <param name = "objge_QuestionStructureGraphRelaENS">源对象</param>
 /// <param name = "objge_QuestionStructureGraphRelaENT">目标对象</param>
public void CopyTo(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaENS, clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaENT)
{
objge_QuestionStructureGraphRelaENT.mId = objge_QuestionStructureGraphRelaENS.mId; //mId
objge_QuestionStructureGraphRelaENT.QuestionId = objge_QuestionStructureGraphRelaENS.QuestionId; //题目Id
objge_QuestionStructureGraphRelaENT.StructureGraphId = objge_QuestionStructureGraphRelaENS.StructureGraphId; //知识图谱Id
objge_QuestionStructureGraphRelaENT.CourseId = objge_QuestionStructureGraphRelaENS.CourseId; //课程Id
objge_QuestionStructureGraphRelaENT.CreateUser = objge_QuestionStructureGraphRelaENS.CreateUser; //建立用户
objge_QuestionStructureGraphRelaENT.UpdDate = objge_QuestionStructureGraphRelaENS.UpdDate; //修改日期
objge_QuestionStructureGraphRelaENT.UpdUser = objge_QuestionStructureGraphRelaENS.UpdUser; //修改人
objge_QuestionStructureGraphRelaENT.Memo = objge_QuestionStructureGraphRelaENS.Memo; //备注
objge_QuestionStructureGraphRelaENT.GameLevelId = objge_QuestionStructureGraphRelaENS.GameLevelId; //游戏关卡Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_QuestionStructureGraphRelaEN.QuestionId, conge_QuestionStructureGraphRela.QuestionId);
clsCheckSql.CheckFieldNotNull(objge_QuestionStructureGraphRelaEN.StructureGraphId, conge_QuestionStructureGraphRela.StructureGraphId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.StructureGraphId, 10, conge_QuestionStructureGraphRela.StructureGraphId);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.CourseId, 8, conge_QuestionStructureGraphRela.CourseId);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.CreateUser, 50, conge_QuestionStructureGraphRela.CreateUser);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.UpdDate, 20, conge_QuestionStructureGraphRela.UpdDate);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.UpdUser, 20, conge_QuestionStructureGraphRela.UpdUser);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.Memo, 1000, conge_QuestionStructureGraphRela.Memo);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.GameLevelId, 8, conge_QuestionStructureGraphRela.GameLevelId);
//检查字段外键固定长度
 objge_QuestionStructureGraphRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.StructureGraphId, 10, conge_QuestionStructureGraphRela.StructureGraphId);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.CourseId, 8, conge_QuestionStructureGraphRela.CourseId);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.CreateUser, 50, conge_QuestionStructureGraphRela.CreateUser);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.UpdDate, 20, conge_QuestionStructureGraphRela.UpdDate);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.UpdUser, 20, conge_QuestionStructureGraphRela.UpdUser);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.Memo, 1000, conge_QuestionStructureGraphRela.Memo);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.GameLevelId, 8, conge_QuestionStructureGraphRela.GameLevelId);
//检查外键字段长度
 objge_QuestionStructureGraphRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.StructureGraphId, 10, conge_QuestionStructureGraphRela.StructureGraphId);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.CourseId, 8, conge_QuestionStructureGraphRela.CourseId);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.CreateUser, 50, conge_QuestionStructureGraphRela.CreateUser);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.UpdDate, 20, conge_QuestionStructureGraphRela.UpdDate);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.UpdUser, 20, conge_QuestionStructureGraphRela.UpdUser);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.Memo, 1000, conge_QuestionStructureGraphRela.Memo);
clsCheckSql.CheckFieldLen(objge_QuestionStructureGraphRelaEN.GameLevelId, 8, conge_QuestionStructureGraphRela.GameLevelId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_QuestionStructureGraphRelaEN.StructureGraphId, conge_QuestionStructureGraphRela.StructureGraphId);
clsCheckSql.CheckSqlInjection4Field(objge_QuestionStructureGraphRelaEN.CourseId, conge_QuestionStructureGraphRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_QuestionStructureGraphRelaEN.CreateUser, conge_QuestionStructureGraphRela.CreateUser);
clsCheckSql.CheckSqlInjection4Field(objge_QuestionStructureGraphRelaEN.UpdDate, conge_QuestionStructureGraphRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_QuestionStructureGraphRelaEN.UpdUser, conge_QuestionStructureGraphRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_QuestionStructureGraphRelaEN.Memo, conge_QuestionStructureGraphRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objge_QuestionStructureGraphRelaEN.GameLevelId, conge_QuestionStructureGraphRela.GameLevelId);
//检查外键字段长度
 objge_QuestionStructureGraphRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_QuestionStructureGraphRela(问题结构图关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_QuestionStructureGraphRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_QuestionStructureGraphRelaEN objge_QuestionStructureGraphRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_QuestionStructureGraphRelaEN.QuestionId);
 sbCondition.AppendFormat(" and StructureGraphId = '{0}'", objge_QuestionStructureGraphRelaEN.StructureGraphId);
 if (objge_QuestionStructureGraphRelaEN.GameLevelId == null)
{
 sbCondition.AppendFormat(" and GameLevelId is null");
}
else
{
 sbCondition.AppendFormat(" and GameLevelId = '{0}'", objge_QuestionStructureGraphRelaEN.GameLevelId);
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_QuestionStructureGraphRelaEN._CurrTabName);
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_QuestionStructureGraphRelaEN._CurrTabName, strCondition);
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
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
 objSQL = clsge_QuestionStructureGraphRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}