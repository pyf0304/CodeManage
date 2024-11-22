
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTSysSkillRelaDA
 表名:vRTSysSkillRela(01120656)
 * 版本:2023.11.03.1(服务器:WIN-SRV103-116)
 日期:2023/11/07 15:53:43
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
 /// vRTSysSkillRela(vRTSysSkillRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTSysSkillRelaDA : clsCommBase4DA
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
 return clsvRTSysSkillRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTSysSkillRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTSysSkillRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTSysSkillRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTSysSkillRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkillRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTSysSkillRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTable_vRTSysSkillRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkillRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkillRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkillRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkillRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTSysSkillRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTSysSkillRela.* from vRTSysSkillRela Left Join {1} on {2} where {3} and vRTSysSkillRela.mId not in (Select top {5} vRTSysSkillRela.mId from vRTSysSkillRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkillRela where {1} and mId not in (Select top {2} mId from vRTSysSkillRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkillRela where {1} and mId not in (Select top {3} mId from vRTSysSkillRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTSysSkillRela.* from vRTSysSkillRela Left Join {1} on {2} where {3} and vRTSysSkillRela.mId not in (Select top {5} vRTSysSkillRela.mId from vRTSysSkillRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkillRela where {1} and mId not in (Select top {2} mId from vRTSysSkillRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTSysSkillRela where {1} and mId not in (Select top {3} mId from vRTSysSkillRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTSysSkillRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA:GetObjLst)", objException.Message));
}
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkillRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = TransNullToBool(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = TransNullToInt(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTSysSkillRelaDA: GetObjLst)", objException.Message));
}
objvRTSysSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTSysSkillRelaEN);
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
public List<clsvRTSysSkillRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = TransNullToBool(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = TransNullToInt(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTSysSkillRelaDA: GetObjLst)", objException.Message));
}
objvRTSysSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTSysSkillRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTSysSkillRela(ref clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkillRela where mId = " + ""+ objvRTSysSkillRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTSysSkillRelaEN.TopicName = objDT.Rows[0][convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSkillRelaEN.SkillName = objDT.Rows[0][convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSkillRelaEN.OperationTypeId = objDT.Rows[0][convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvRTSysSkillRelaEN.Process = objDT.Rows[0][convRTSysSkillRela.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSkillRelaEN.LevelId = objDT.Rows[0][convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTSysSkillRelaEN.LevelName = objDT.Rows[0][convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSkillRelaEN.SkillUpdUser = objDT.Rows[0][convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.SkillUpdDate = objDT.Rows[0][convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convRTSysSkillRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.IdCurrEduCls = objDT.Rows[0][convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTSysSkillRelaEN.TopicProposePeople = objDT.Rows[0][convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSkillRelaEN.TopicContent = objDT.Rows[0][convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSkillRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTSysSkillRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.Score = TransNullToFloat(objDT.Rows[0][convRTSysSkillRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.PdfContent = objDT.Rows[0][convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTSysSkillRelaEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.OperationTypeName = objDT.Rows[0][convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvRTSysSkillRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.CitationId = objDT.Rows[0][convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.mId = TransNullToInt(objDT.Rows[0][convRTSysSkillRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.TopicId = objDT.Rows[0][convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.SkillId = objDT.Rows[0][convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objvRTSysSkillRelaEN.UpdDate = objDT.Rows[0][convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.Memo = objDT.Rows[0][convRTSysSkillRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTSysSkillRelaEN.UpdUser = objDT.Rows[0][convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.CreateDate = objDT.Rows[0][convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.ShareId = objDT.Rows[0][convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTSysSkillRelaEN.ClassificationId = objDT.Rows[0][convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTSysSkillRelaDA: GetvRTSysSkillRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTSysSkillRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkillRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
 objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id(字段类型:char,字段长度:10,是否可空:False)
 objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTSysSkillRelaDA: GetObjBymId)", objException.Message));
}
return objvRTSysSkillRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTSysSkillRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTSysSkillRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN()
{
TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(), //栏目主题
SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(), //技能名称
OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(), //操作类型ID
Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(), //实施过程
LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(), //级别Id
LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(), //级别名称
SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(), //SkillUpdUser
SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(), //SkillUpdDate
OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()), //序号
IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(), //主题提出人
TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(), //主题内容
IsSubmit = TransNullToBool(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.Score].ToString().Trim()), //评分
StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()), //教师评分
PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()), //版本统计
OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(), //操作类型名
OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OkCount].ToString().Trim()), //点赞统计
CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(), //引用Id
mId = TransNullToInt(objRow[convRTSysSkillRela.mId].ToString().Trim()), //mId
TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(), //主题Id
SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(), //技能Id
UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(), //备注
UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(), //分享Id
ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim() //分类Id
};
objvRTSysSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSkillRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTSysSkillRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTSysSkillRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = TransNullToBool(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = TransNullToInt(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTSysSkillRelaDA: GetObjByDataRowvRTSysSkillRela)", objException.Message));
}
objvRTSysSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSkillRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTSysSkillRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = TransNullToBool(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = TransNullToInt(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTSysSkillRelaDA: GetObjByDataRow)", objException.Message));
}
objvRTSysSkillRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTSysSkillRelaEN;
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
objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTSysSkillRelaEN._CurrTabName, convRTSysSkillRela.mId, 8, "");
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
objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTSysSkillRelaEN._CurrTabName, convRTSysSkillRela.mId, 8, strPrefix);
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
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vRTSysSkillRela where " + strCondition;
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
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vRTSysSkillRela where " + strCondition;
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
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTSysSkillRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTSysSkillRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTSysSkillRela", strCondition))
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
objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTSysSkillRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaENS">源对象</param>
 /// <param name = "objvRTSysSkillRelaENT">目标对象</param>
public void CopyTo(clsvRTSysSkillRelaEN objvRTSysSkillRelaENS, clsvRTSysSkillRelaEN objvRTSysSkillRelaENT)
{
objvRTSysSkillRelaENT.TopicName = objvRTSysSkillRelaENS.TopicName; //栏目主题
objvRTSysSkillRelaENT.SkillName = objvRTSysSkillRelaENS.SkillName; //技能名称
objvRTSysSkillRelaENT.OperationTypeId = objvRTSysSkillRelaENS.OperationTypeId; //操作类型ID
objvRTSysSkillRelaENT.Process = objvRTSysSkillRelaENS.Process; //实施过程
objvRTSysSkillRelaENT.LevelId = objvRTSysSkillRelaENS.LevelId; //级别Id
objvRTSysSkillRelaENT.LevelName = objvRTSysSkillRelaENS.LevelName; //级别名称
objvRTSysSkillRelaENT.SkillUpdUser = objvRTSysSkillRelaENS.SkillUpdUser; //SkillUpdUser
objvRTSysSkillRelaENT.SkillUpdDate = objvRTSysSkillRelaENS.SkillUpdDate; //SkillUpdDate
objvRTSysSkillRelaENT.OrderNum = objvRTSysSkillRelaENS.OrderNum; //序号
objvRTSysSkillRelaENT.IdCurrEduCls = objvRTSysSkillRelaENS.IdCurrEduCls; //教学班流水号
objvRTSysSkillRelaENT.TopicProposePeople = objvRTSysSkillRelaENS.TopicProposePeople; //主题提出人
objvRTSysSkillRelaENT.TopicContent = objvRTSysSkillRelaENS.TopicContent; //主题内容
objvRTSysSkillRelaENT.IsSubmit = objvRTSysSkillRelaENS.IsSubmit; //是否提交
objvRTSysSkillRelaENT.AppraiseCount = objvRTSysSkillRelaENS.AppraiseCount; //评论数
objvRTSysSkillRelaENT.Score = objvRTSysSkillRelaENS.Score; //评分
objvRTSysSkillRelaENT.StuScore = objvRTSysSkillRelaENS.StuScore; //学生平均分
objvRTSysSkillRelaENT.TeaScore = objvRTSysSkillRelaENS.TeaScore; //教师评分
objvRTSysSkillRelaENT.PdfContent = objvRTSysSkillRelaENS.PdfContent; //Pdf内容
objvRTSysSkillRelaENT.PdfPageNum = objvRTSysSkillRelaENS.PdfPageNum; //Pdf页码
objvRTSysSkillRelaENT.CitationCount = objvRTSysSkillRelaENS.CitationCount; //引用统计
objvRTSysSkillRelaENT.VersionCount = objvRTSysSkillRelaENS.VersionCount; //版本统计
objvRTSysSkillRelaENT.OperationTypeName = objvRTSysSkillRelaENS.OperationTypeName; //操作类型名
objvRTSysSkillRelaENT.OkCount = objvRTSysSkillRelaENS.OkCount; //点赞统计
objvRTSysSkillRelaENT.CitationId = objvRTSysSkillRelaENS.CitationId; //引用Id
objvRTSysSkillRelaENT.mId = objvRTSysSkillRelaENS.mId; //mId
objvRTSysSkillRelaENT.TopicId = objvRTSysSkillRelaENS.TopicId; //主题Id
objvRTSysSkillRelaENT.SkillId = objvRTSysSkillRelaENS.SkillId; //技能Id
objvRTSysSkillRelaENT.UpdDate = objvRTSysSkillRelaENS.UpdDate; //修改日期
objvRTSysSkillRelaENT.Memo = objvRTSysSkillRelaENS.Memo; //备注
objvRTSysSkillRelaENT.UpdUser = objvRTSysSkillRelaENS.UpdUser; //修改人
objvRTSysSkillRelaENT.CreateDate = objvRTSysSkillRelaENS.CreateDate; //建立日期
objvRTSysSkillRelaENT.ShareId = objvRTSysSkillRelaENS.ShareId; //分享Id
objvRTSysSkillRelaENT.ClassificationId = objvRTSysSkillRelaENS.ClassificationId; //分类Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.TopicName, 200, convRTSysSkillRela.TopicName);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.SkillName, 200, convRTSysSkillRela.SkillName);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.OperationTypeId, 4, convRTSysSkillRela.OperationTypeId);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.LevelId, 2, convRTSysSkillRela.LevelId);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.LevelName, 50, convRTSysSkillRela.LevelName);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.SkillUpdUser, 20, convRTSysSkillRela.SkillUpdUser);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.SkillUpdDate, 20, convRTSysSkillRela.SkillUpdDate);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.IdCurrEduCls, 8, convRTSysSkillRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.TopicProposePeople, 50, convRTSysSkillRela.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.PdfContent, 2000, convRTSysSkillRela.PdfContent);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.OperationTypeName, 50, convRTSysSkillRela.OperationTypeName);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.CitationId, 8, convRTSysSkillRela.CitationId);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.TopicId, 8, convRTSysSkillRela.TopicId);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.SkillId, 10, convRTSysSkillRela.SkillId);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.UpdDate, 20, convRTSysSkillRela.UpdDate);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.Memo, 1000, convRTSysSkillRela.Memo);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.UpdUser, 20, convRTSysSkillRela.UpdUser);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.CreateDate, 20, convRTSysSkillRela.CreateDate);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.ShareId, 2, convRTSysSkillRela.ShareId);
clsCheckSql.CheckFieldLen(objvRTSysSkillRelaEN.ClassificationId, 10, convRTSysSkillRela.ClassificationId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.TopicName, convRTSysSkillRela.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.SkillName, convRTSysSkillRela.SkillName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.OperationTypeId, convRTSysSkillRela.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.LevelId, convRTSysSkillRela.LevelId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.LevelName, convRTSysSkillRela.LevelName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.SkillUpdUser, convRTSysSkillRela.SkillUpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.SkillUpdDate, convRTSysSkillRela.SkillUpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.IdCurrEduCls, convRTSysSkillRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.TopicProposePeople, convRTSysSkillRela.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.PdfContent, convRTSysSkillRela.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.OperationTypeName, convRTSysSkillRela.OperationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.CitationId, convRTSysSkillRela.CitationId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.TopicId, convRTSysSkillRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.SkillId, convRTSysSkillRela.SkillId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.UpdDate, convRTSysSkillRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.Memo, convRTSysSkillRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.UpdUser, convRTSysSkillRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.CreateDate, convRTSysSkillRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.ShareId, convRTSysSkillRela.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvRTSysSkillRelaEN.ClassificationId, convRTSysSkillRela.ClassificationId);
//检查外键字段长度
 objvRTSysSkillRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetmId()
{
//获取某学院所有专业信息
string strSQL = "select mId, LevelId from vRTSysSkillRela ";
 clsSpecSQLforSql mySql = clsvRTSysSkillRelaDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vRTSysSkillRela(vRTSysSkillRela),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillRelaEN.mId);
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
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTSysSkillRelaEN._CurrTabName);
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
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTSysSkillRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvRTSysSkillRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}