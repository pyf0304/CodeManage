
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PTopicObjectiveRelaDA
 表名:vgs_PTopicObjectiveRela(01120667)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 论文客观关系视图(vgs_PTopicObjectiveRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_PTopicObjectiveRelaDA : clsCommBase4DA
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
 return clsvgs_PTopicObjectiveRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_PTopicObjectiveRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PTopicObjectiveRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_PTopicObjectiveRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_PTopicObjectiveRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PTopicObjectiveRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_PTopicObjectiveRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTable_vgs_PTopicObjectiveRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PTopicObjectiveRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PTopicObjectiveRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PTopicObjectiveRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PTopicObjectiveRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_PTopicObjectiveRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PTopicObjectiveRela.* from vgs_PTopicObjectiveRela Left Join {1} on {2} where {3} and vgs_PTopicObjectiveRela.mId not in (Select top {5} vgs_PTopicObjectiveRela.mId from vgs_PTopicObjectiveRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PTopicObjectiveRela where {1} and mId not in (Select top {2} mId from vgs_PTopicObjectiveRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PTopicObjectiveRela where {1} and mId not in (Select top {3} mId from vgs_PTopicObjectiveRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_PTopicObjectiveRela.* from vgs_PTopicObjectiveRela Left Join {1} on {2} where {3} and vgs_PTopicObjectiveRela.mId not in (Select top {5} vgs_PTopicObjectiveRela.mId from vgs_PTopicObjectiveRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_PTopicObjectiveRela where {1} and mId not in (Select top {2} mId from vgs_PTopicObjectiveRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_PTopicObjectiveRela where {1} and mId not in (Select top {3} mId from vgs_PTopicObjectiveRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_PTopicObjectiveRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA:GetObjLst)", objException.Message));
}
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PTopicObjectiveRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = TransNullToInt(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetObjLst)", objException.Message));
}
objvgs_PTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
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
public List<clsvgs_PTopicObjectiveRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = TransNullToInt(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetObjLst)", objException.Message));
}
objvgs_PTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_PTopicObjectiveRela(ref clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PTopicObjectiveRela where mId = " + ""+ objvgs_PTopicObjectiveRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_PTopicObjectiveRelaEN.mId = TransNullToInt(objDT.Rows[0][convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.PaperId = objDT.Rows[0][convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.PaperTitle = objDT.Rows[0][convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PTopicObjectiveRelaEN.PaperTypeId = objDT.Rows[0][convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.SectionId = objDT.Rows[0][convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.SectionName = objDT.Rows[0][convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objDT.Rows[0][convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_PTopicObjectiveRelaEN.ObjectiveName = objDT.Rows[0][convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objDT.Rows[0][convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjectiveType = objDT.Rows[0][convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objDT.Rows[0][convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName(字段类型:varchar,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.Score = TransNullToFloat(objDT.Rows[0][convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.UpdDate = objDT.Rows[0][convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.UpdUser = objDT.Rows[0][convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.Memo = objDT.Rows[0][convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjUserId = objDT.Rows[0][convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjDate = objDT.Rows[0][convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.Conclusion = objDT.Rows[0][convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.CreateDate = objDT.Rows[0][convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ShareId = objDT.Rows[0][convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_PTopicObjectiveRelaDA: Getvgs_PTopicObjectiveRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_PTopicObjectiveRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PTopicObjectiveRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
 objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName(字段类型:varchar,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId(字段类型:varchar,字段长度:50,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetObjBymId)", objException.Message));
}
return objvgs_PTopicObjectiveRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_PTopicObjectiveRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vgs_PTopicObjectiveRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN()
{
mId = TransNullToInt(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()), //mId
PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(), //论文标题
PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(), //论文类型Id
SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(), //节Id
SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(), //节名
TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(), //客观Id
ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(), //客观内容
ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(), //客观类型
IsSubmit = TransNullToBool(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()), //是否提交
ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(), //ObjectiveTypeName
TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()), //教师评分
StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()), //学生平均分
Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()), //评分
AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()), //点赞统计
VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()), //版本统计
CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()), //引用统计
UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(), //备注
ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(), //ObjUserId
ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(), //ObjDate
Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(), //结论
CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim() //分享Id
};
objvgs_PTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PTopicObjectiveRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_PTopicObjectiveRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = TransNullToInt(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetObjByDataRowvgs_PTopicObjectiveRela)", objException.Message));
}
objvgs_PTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PTopicObjectiveRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_PTopicObjectiveRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = TransNullToInt(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_PTopicObjectiveRelaDA: GetObjByDataRow)", objException.Message));
}
objvgs_PTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_PTopicObjectiveRelaEN;
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
objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PTopicObjectiveRelaEN._CurrTabName, convgs_PTopicObjectiveRela.mId, 8, "");
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
objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_PTopicObjectiveRelaEN._CurrTabName, convgs_PTopicObjectiveRela.mId, 8, strPrefix);
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
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vgs_PTopicObjectiveRela where " + strCondition;
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
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vgs_PTopicObjectiveRela where " + strCondition;
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
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PTopicObjectiveRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_PTopicObjectiveRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_PTopicObjectiveRela", strCondition))
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
objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_PTopicObjectiveRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaENS">源对象</param>
 /// <param name = "objvgs_PTopicObjectiveRelaENT">目标对象</param>
public void CopyTo(clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaENS, clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaENT)
{
objvgs_PTopicObjectiveRelaENT.mId = objvgs_PTopicObjectiveRelaENS.mId; //mId
objvgs_PTopicObjectiveRelaENT.PaperId = objvgs_PTopicObjectiveRelaENS.PaperId; //论文Id
objvgs_PTopicObjectiveRelaENT.PaperTitle = objvgs_PTopicObjectiveRelaENS.PaperTitle; //论文标题
objvgs_PTopicObjectiveRelaENT.PaperTypeId = objvgs_PTopicObjectiveRelaENS.PaperTypeId; //论文类型Id
objvgs_PTopicObjectiveRelaENT.SectionId = objvgs_PTopicObjectiveRelaENS.SectionId; //节Id
objvgs_PTopicObjectiveRelaENT.SectionName = objvgs_PTopicObjectiveRelaENS.SectionName; //节名
objvgs_PTopicObjectiveRelaENT.TopicObjectiveId = objvgs_PTopicObjectiveRelaENS.TopicObjectiveId; //客观Id
objvgs_PTopicObjectiveRelaENT.ObjectiveName = objvgs_PTopicObjectiveRelaENS.ObjectiveName; //客观名称
objvgs_PTopicObjectiveRelaENT.ObjectiveContent = objvgs_PTopicObjectiveRelaENS.ObjectiveContent; //客观内容
objvgs_PTopicObjectiveRelaENT.ObjectiveType = objvgs_PTopicObjectiveRelaENS.ObjectiveType; //客观类型
objvgs_PTopicObjectiveRelaENT.IsSubmit = objvgs_PTopicObjectiveRelaENS.IsSubmit; //是否提交
objvgs_PTopicObjectiveRelaENT.ObjectiveTypeName = objvgs_PTopicObjectiveRelaENS.ObjectiveTypeName; //ObjectiveTypeName
objvgs_PTopicObjectiveRelaENT.TeaScore = objvgs_PTopicObjectiveRelaENS.TeaScore; //教师评分
objvgs_PTopicObjectiveRelaENT.StuScore = objvgs_PTopicObjectiveRelaENS.StuScore; //学生平均分
objvgs_PTopicObjectiveRelaENT.Score = objvgs_PTopicObjectiveRelaENS.Score; //评分
objvgs_PTopicObjectiveRelaENT.AppraiseCount = objvgs_PTopicObjectiveRelaENS.AppraiseCount; //评论数
objvgs_PTopicObjectiveRelaENT.OkCount = objvgs_PTopicObjectiveRelaENS.OkCount; //点赞统计
objvgs_PTopicObjectiveRelaENT.VersionCount = objvgs_PTopicObjectiveRelaENS.VersionCount; //版本统计
objvgs_PTopicObjectiveRelaENT.CitationCount = objvgs_PTopicObjectiveRelaENS.CitationCount; //引用统计
objvgs_PTopicObjectiveRelaENT.UpdDate = objvgs_PTopicObjectiveRelaENS.UpdDate; //修改日期
objvgs_PTopicObjectiveRelaENT.UpdUser = objvgs_PTopicObjectiveRelaENS.UpdUser; //修改人
objvgs_PTopicObjectiveRelaENT.Memo = objvgs_PTopicObjectiveRelaENS.Memo; //备注
objvgs_PTopicObjectiveRelaENT.ObjUserId = objvgs_PTopicObjectiveRelaENS.ObjUserId; //ObjUserId
objvgs_PTopicObjectiveRelaENT.ObjDate = objvgs_PTopicObjectiveRelaENS.ObjDate; //ObjDate
objvgs_PTopicObjectiveRelaENT.Conclusion = objvgs_PTopicObjectiveRelaENS.Conclusion; //结论
objvgs_PTopicObjectiveRelaENT.CreateDate = objvgs_PTopicObjectiveRelaENS.CreateDate; //建立日期
objvgs_PTopicObjectiveRelaENT.ShareId = objvgs_PTopicObjectiveRelaENS.ShareId; //分享Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.PaperId, 8, convgs_PTopicObjectiveRela.PaperId);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.PaperTitle, 500, convgs_PTopicObjectiveRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.PaperTypeId, 2, convgs_PTopicObjectiveRela.PaperTypeId);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.SectionId, 8, convgs_PTopicObjectiveRela.SectionId);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.SectionName, 100, convgs_PTopicObjectiveRela.SectionName);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.TopicObjectiveId, 8, convgs_PTopicObjectiveRela.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.ObjectiveName, 500, convgs_PTopicObjectiveRela.ObjectiveName);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.ObjectiveType, 2, convgs_PTopicObjectiveRela.ObjectiveType);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName, 8, convgs_PTopicObjectiveRela.ObjectiveTypeName);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.UpdDate, 20, convgs_PTopicObjectiveRela.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.UpdUser, 20, convgs_PTopicObjectiveRela.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.Memo, 1000, convgs_PTopicObjectiveRela.Memo);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.ObjUserId, 50, convgs_PTopicObjectiveRela.ObjUserId);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.ObjDate, 20, convgs_PTopicObjectiveRela.ObjDate);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.CreateDate, 20, convgs_PTopicObjectiveRela.CreateDate);
clsCheckSql.CheckFieldLen(objvgs_PTopicObjectiveRelaEN.ShareId, 2, convgs_PTopicObjectiveRela.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.PaperId, convgs_PTopicObjectiveRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.PaperTitle, convgs_PTopicObjectiveRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.PaperTypeId, convgs_PTopicObjectiveRela.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.SectionId, convgs_PTopicObjectiveRela.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.SectionName, convgs_PTopicObjectiveRela.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.TopicObjectiveId, convgs_PTopicObjectiveRela.TopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.ObjectiveName, convgs_PTopicObjectiveRela.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.ObjectiveType, convgs_PTopicObjectiveRela.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName, convgs_PTopicObjectiveRela.ObjectiveTypeName);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.UpdDate, convgs_PTopicObjectiveRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.UpdUser, convgs_PTopicObjectiveRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.Memo, convgs_PTopicObjectiveRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.ObjUserId, convgs_PTopicObjectiveRela.ObjUserId);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.ObjDate, convgs_PTopicObjectiveRela.ObjDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.CreateDate, convgs_PTopicObjectiveRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_PTopicObjectiveRelaEN.ShareId, convgs_PTopicObjectiveRela.ShareId);
//检查外键字段长度
 objvgs_PTopicObjectiveRelaEN._IsCheckProperty = true;
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
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
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
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PTopicObjectiveRelaEN._CurrTabName);
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
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_PTopicObjectiveRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_PTopicObjectiveRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}