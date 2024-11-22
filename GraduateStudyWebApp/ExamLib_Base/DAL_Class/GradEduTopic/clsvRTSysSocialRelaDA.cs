
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTSysSocialRelaDA
 表名:vRTSysSocialRela(01120655)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// vRTSysSocialRela(vRTSysSocialRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTSysSocialRelaDA : clsCommBase4DA
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
 return clsvRTSysSocialRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTSysSocialRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTSysSocialRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTSysSocialRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTSysSocialRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTSysSocialRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTable_vRTSysSocialRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSocialRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSocialRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSocialRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSocialRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTSysSocialRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTSysSocialRela.* from vRTSysSocialRela Left Join {1} on {2} where {3} and vRTSysSocialRela.SubViewpointId not in (Select top {5} vRTSysSocialRela.SubViewpointId from vRTSysSocialRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSocialRela where {1} and SubViewpointId not in (Select top {2} SubViewpointId from vRTSysSocialRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSocialRela where {1} and SubViewpointId not in (Select top {3} SubViewpointId from vRTSysSocialRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTSysSocialRela.* from vRTSysSocialRela Left Join {1} on {2} where {3} and vRTSysSocialRela.SubViewpointId not in (Select top {5} vRTSysSocialRela.SubViewpointId from vRTSysSocialRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSocialRela where {1} and SubViewpointId not in (Select top {2} SubViewpointId from vRTSysSocialRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSocialRela where {1} and SubViewpointId not in (Select top {3} SubViewpointId from vRTSysSocialRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTSysSocialRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA:GetObjLst)", objException.Message));
}
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = TransNullToInt(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = TransNullToBool(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTSysSocialRelaDA: GetObjLst)", objException.Message));
}
objvRTSysSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTSysSocialRelaEN);
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
public List<clsvRTSysSocialRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = TransNullToInt(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = TransNullToBool(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTSysSocialRelaDA: GetObjLst)", objException.Message));
}
objvRTSysSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTSysSocialRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTSysSocialRela(ref clsvRTSysSocialRelaEN objvRTSysSocialRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSocialRela where SubViewpointId = " + ""+ objvRTSysSocialRelaEN.SubViewpointId+"" + " and TopicId = " + "'"+ objvRTSysSocialRelaEN.TopicId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTSysSocialRelaEN.SubViewpointId = TransNullToInt(objDT.Rows[0][convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.TopicId = objDT.Rows[0][convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.TopicName = objDT.Rows[0][convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSocialRelaEN.TopicContent = objDT.Rows[0][convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSocialRelaEN.TopicProposePeople = objDT.Rows[0][convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convRTSysSocialRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSocialRelaEN.IdCurrEduCls = objDT.Rows[0][convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTSysSocialRelaEN.FullName = objDT.Rows[0][convRTSysSocialRela.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.Nationality = objDT.Rows[0][convRTSysSocialRela.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.WorkUnit = objDT.Rows[0][convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTSysSocialRelaEN.Major = objDT.Rows[0][convRTSysSocialRela.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.Achievement = objDT.Rows[0][convRTSysSocialRela.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTSysSocialRelaEN.DetailedDescription = objDT.Rows[0][convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTSysSocialRelaEN.LevelId = objDT.Rows[0][convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTSysSocialRelaEN.LevelName = objDT.Rows[0][convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.SocialUpdUser = objDT.Rows[0][convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.SocialUpdDate = objDT.Rows[0][convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTSysSocialRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSocialRelaEN.UpdDate = objDT.Rows[0][convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.UpdUser = objDT.Rows[0][convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.Memo = objDT.Rows[0][convRTSysSocialRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTSysSocialRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSocialRelaEN.Score = TransNullToFloat(objDT.Rows[0][convRTSysSocialRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.CreateDate = objDT.Rows[0][convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.ShareId = objDT.Rows[0][convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTSysSocialRelaEN.PdfContent = objDT.Rows[0][convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTSysSocialRelaEN.ClassificationId = TransNullToInt(objDT.Rows[0][convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvRTSysSocialRelaEN.PaperId = objDT.Rows[0][convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTSysSocialRelaDA: GetvRTSysSocialRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTSysSocialRelaEN GetObjByKeyLst(long lngSubViewpointId,string strTopicId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSocialRela where SubViewpointId = " + ""+ lngSubViewpointId+"" + " and TopicId = " + "'"+ strTopicId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
 objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTSysSocialRelaDA: GetObjByKeyLst)", objException.Message));
}
return objvRTSysSocialRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTSysSocialRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSocialRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN()
{
SubViewpointId = TransNullToInt(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()), //子观点Id
TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(), //主题Id
TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(), //栏目主题
TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(), //主题内容
TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(), //主题提出人
OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()), //序号
IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(), //姓名
Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(), //国籍
WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(), //工作单位
Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(), //专业
Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(), //成就
DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(), //详细说明
LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(), //级别Id
LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(), //级别名称
SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(), //SocialUpdUser
SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(), //SocialUpdDate
IsSubmit = TransNullToBool(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()), //是否提交
OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OkCount].ToString().Trim()), //点赞统计
UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(), //备注
AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.Score].ToString().Trim()), //评分
StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()), //教师评分
CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(), //分享Id
PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(), //Pdf内容
ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()), //分类Id
PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim() //论文Id
};
objvRTSysSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSocialRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTSysSocialRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTSysSocialRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = TransNullToInt(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = TransNullToBool(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTSysSocialRelaDA: GetObjByDataRowvRTSysSocialRela)", objException.Message));
}
objvRTSysSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSocialRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTSysSocialRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = TransNullToInt(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = TransNullToBool(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTSysSocialRelaDA: GetObjByDataRow)", objException.Message));
}
objvRTSysSocialRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSocialRelaEN;
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
objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTSysSocialRelaEN._CurrTabName, convRTSysSocialRela.SubViewpointId, 8, "");
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
objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTSysSocialRelaEN._CurrTabName, convRTSysSocialRela.SubViewpointId, 8, strPrefix);
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
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SubViewpointId,TopicId from vRTSysSocialRela where " + strCondition;
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
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SubViewpointId,TopicId from vRTSysSocialRela where " + strCondition;
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
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngSubViewpointId, string strTopicId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTSysSocialRela", "SubViewpointId = " + ""+ lngSubViewpointId+"" + " and TopicId = " + "'"+ strTopicId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTSysSocialRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTSysSocialRela", strCondition))
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
objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTSysSocialRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaENS">源对象</param>
 /// <param name = "objvRTSysSocialRelaENT">目标对象</param>
public void CopyTo(clsvRTSysSocialRelaEN objvRTSysSocialRelaENS, clsvRTSysSocialRelaEN objvRTSysSocialRelaENT)
{
objvRTSysSocialRelaENT.SubViewpointId = objvRTSysSocialRelaENS.SubViewpointId; //子观点Id
objvRTSysSocialRelaENT.TopicId = objvRTSysSocialRelaENS.TopicId; //主题Id
objvRTSysSocialRelaENT.TopicName = objvRTSysSocialRelaENS.TopicName; //栏目主题
objvRTSysSocialRelaENT.TopicContent = objvRTSysSocialRelaENS.TopicContent; //主题内容
objvRTSysSocialRelaENT.TopicProposePeople = objvRTSysSocialRelaENS.TopicProposePeople; //主题提出人
objvRTSysSocialRelaENT.OrderNum = objvRTSysSocialRelaENS.OrderNum; //序号
objvRTSysSocialRelaENT.IdCurrEduCls = objvRTSysSocialRelaENS.IdCurrEduCls; //教学班流水号
objvRTSysSocialRelaENT.FullName = objvRTSysSocialRelaENS.FullName; //姓名
objvRTSysSocialRelaENT.Nationality = objvRTSysSocialRelaENS.Nationality; //国籍
objvRTSysSocialRelaENT.WorkUnit = objvRTSysSocialRelaENS.WorkUnit; //工作单位
objvRTSysSocialRelaENT.Major = objvRTSysSocialRelaENS.Major; //专业
objvRTSysSocialRelaENT.Achievement = objvRTSysSocialRelaENS.Achievement; //成就
objvRTSysSocialRelaENT.DetailedDescription = objvRTSysSocialRelaENS.DetailedDescription; //详细说明
objvRTSysSocialRelaENT.LevelId = objvRTSysSocialRelaENS.LevelId; //级别Id
objvRTSysSocialRelaENT.LevelName = objvRTSysSocialRelaENS.LevelName; //级别名称
objvRTSysSocialRelaENT.SocialUpdUser = objvRTSysSocialRelaENS.SocialUpdUser; //SocialUpdUser
objvRTSysSocialRelaENT.SocialUpdDate = objvRTSysSocialRelaENS.SocialUpdDate; //SocialUpdDate
objvRTSysSocialRelaENT.IsSubmit = objvRTSysSocialRelaENS.IsSubmit; //是否提交
objvRTSysSocialRelaENT.OkCount = objvRTSysSocialRelaENS.OkCount; //点赞统计
objvRTSysSocialRelaENT.UpdDate = objvRTSysSocialRelaENS.UpdDate; //修改日期
objvRTSysSocialRelaENT.UpdUser = objvRTSysSocialRelaENS.UpdUser; //修改人
objvRTSysSocialRelaENT.Memo = objvRTSysSocialRelaENS.Memo; //备注
objvRTSysSocialRelaENT.AppraiseCount = objvRTSysSocialRelaENS.AppraiseCount; //评论数
objvRTSysSocialRelaENT.Score = objvRTSysSocialRelaENS.Score; //评分
objvRTSysSocialRelaENT.StuScore = objvRTSysSocialRelaENS.StuScore; //学生平均分
objvRTSysSocialRelaENT.TeaScore = objvRTSysSocialRelaENS.TeaScore; //教师评分
objvRTSysSocialRelaENT.CreateDate = objvRTSysSocialRelaENS.CreateDate; //建立日期
objvRTSysSocialRelaENT.ShareId = objvRTSysSocialRelaENS.ShareId; //分享Id
objvRTSysSocialRelaENT.PdfContent = objvRTSysSocialRelaENS.PdfContent; //Pdf内容
objvRTSysSocialRelaENT.ClassificationId = objvRTSysSocialRelaENS.ClassificationId; //分类Id
objvRTSysSocialRelaENT.PaperId = objvRTSysSocialRelaENS.PaperId; //论文Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTSysSocialRelaEN objvRTSysSocialRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.TopicId, 8, convRTSysSocialRela.TopicId);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.TopicName, 200, convRTSysSocialRela.TopicName);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.TopicProposePeople, 50, convRTSysSocialRela.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.IdCurrEduCls, 8, convRTSysSocialRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.FullName, 50, convRTSysSocialRela.FullName);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.Nationality, 50, convRTSysSocialRela.Nationality);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.WorkUnit, 100, convRTSysSocialRela.WorkUnit);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.Major, 50, convRTSysSocialRela.Major);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.Achievement, 5000, convRTSysSocialRela.Achievement);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.DetailedDescription, 5000, convRTSysSocialRela.DetailedDescription);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.LevelId, 2, convRTSysSocialRela.LevelId);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.LevelName, 50, convRTSysSocialRela.LevelName);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.SocialUpdUser, 20, convRTSysSocialRela.SocialUpdUser);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.SocialUpdDate, 20, convRTSysSocialRela.SocialUpdDate);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.UpdDate, 20, convRTSysSocialRela.UpdDate);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.UpdUser, 20, convRTSysSocialRela.UpdUser);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.Memo, 1000, convRTSysSocialRela.Memo);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.CreateDate, 20, convRTSysSocialRela.CreateDate);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.ShareId, 2, convRTSysSocialRela.ShareId);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.PdfContent, 2000, convRTSysSocialRela.PdfContent);
clsCheckSql.CheckFieldLen(objvRTSysSocialRelaEN.PaperId, 8, convRTSysSocialRela.PaperId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.TopicId, convRTSysSocialRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.TopicName, convRTSysSocialRela.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.TopicProposePeople, convRTSysSocialRela.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.IdCurrEduCls, convRTSysSocialRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.FullName, convRTSysSocialRela.FullName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.Nationality, convRTSysSocialRela.Nationality);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.WorkUnit, convRTSysSocialRela.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.Major, convRTSysSocialRela.Major);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.Achievement, convRTSysSocialRela.Achievement);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.DetailedDescription, convRTSysSocialRela.DetailedDescription);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.LevelId, convRTSysSocialRela.LevelId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.LevelName, convRTSysSocialRela.LevelName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.SocialUpdUser, convRTSysSocialRela.SocialUpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.SocialUpdDate, convRTSysSocialRela.SocialUpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.UpdDate, convRTSysSocialRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.UpdUser, convRTSysSocialRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.Memo, convRTSysSocialRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.CreateDate, convRTSysSocialRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.ShareId, convRTSysSocialRela.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.PdfContent, convRTSysSocialRela.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSocialRelaEN.PaperId, convRTSysSocialRela.PaperId);
//检查外键字段长度
 objvRTSysSocialRelaEN._IsCheckProperty = true;
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
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTSysSocialRelaEN._CurrTabName);
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
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTSysSocialRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvRTSysSocialRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}