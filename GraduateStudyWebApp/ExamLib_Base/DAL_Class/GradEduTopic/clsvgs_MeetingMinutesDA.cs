
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_MeetingMinutesDA
 表名:vgs_MeetingMinutes(01120768)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:38:17
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
 /// 会议纪要视图(vgs_MeetingMinutes)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvgs_MeetingMinutesDA : clsCommBase4DA
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
 return clsvgs_MeetingMinutesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvgs_MeetingMinutesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_MeetingMinutesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvgs_MeetingMinutesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvgs_MeetingMinutesEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMeetingId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMeetingId)
{
strMeetingId = strMeetingId.Replace("'", "''");
if (strMeetingId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vgs_MeetingMinutes中,检查关键字,长度不正确!(clsvgs_MeetingMinutesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMeetingId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vgs_MeetingMinutes中,关键字不能为空 或 null!(clsvgs_MeetingMinutesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMeetingId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvgs_MeetingMinutesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from vgs_MeetingMinutes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vgs_MeetingMinutes(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTable_vgs_MeetingMinutes)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from vgs_MeetingMinutes where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from vgs_MeetingMinutes where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_MeetingMinutes where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_MeetingMinutes where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vgs_MeetingMinutes where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_MeetingMinutes.* from vgs_MeetingMinutes Left Join {1} on {2} where {3} and vgs_MeetingMinutes.MeetingId not in (Select top {5} vgs_MeetingMinutes.MeetingId from vgs_MeetingMinutes Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_MeetingMinutes where {1} and MeetingId not in (Select top {2} MeetingId from vgs_MeetingMinutes where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_MeetingMinutes where {1} and MeetingId not in (Select top {3} MeetingId from vgs_MeetingMinutes where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vgs_MeetingMinutes.* from vgs_MeetingMinutes Left Join {1} on {2} where {3} and vgs_MeetingMinutes.MeetingId not in (Select top {5} vgs_MeetingMinutes.MeetingId from vgs_MeetingMinutes Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vgs_MeetingMinutes where {1} and MeetingId not in (Select top {2} MeetingId from vgs_MeetingMinutes where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vgs_MeetingMinutes where {1} and MeetingId not in (Select top {3} MeetingId from vgs_MeetingMinutes where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvgs_MeetingMinutesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA:GetObjLst)", objException.Message));
}
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from vgs_MeetingMinutes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = TransNullToBool(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_MeetingMinutesDA: GetObjLst)", objException.Message));
}
objvgs_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_MeetingMinutesEN);
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
public List<clsvgs_MeetingMinutesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA:GetObjLstByTabName)", objException.Message));
}
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = TransNullToBool(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvgs_MeetingMinutesDA: GetObjLst)", objException.Message));
}
objvgs_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvgs_MeetingMinutesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvgs_MeetingMinutes(ref clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from vgs_MeetingMinutes where MeetingId = " + "'"+ objvgs_MeetingMinutesEN.MeetingId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvgs_MeetingMinutesEN.MeetingId = objDT.Rows[0][convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_MeetingMinutesEN.TopicId = objDT.Rows[0][convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_MeetingMinutesEN.IsSubmit = TransNullToBool(objDT.Rows[0][convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_MeetingMinutesEN.TopicName = objDT.Rows[0][convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_MeetingMinutesEN.MeetingContent = objDT.Rows[0][convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_MeetingMinutesEN.MeetingDate = objDT.Rows[0][convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_MeetingMinutesEN.UpdDate = objDT.Rows[0][convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_MeetingMinutesEN.UpdUser = objDT.Rows[0][convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_MeetingMinutesEN.Year = objDT.Rows[0][convgs_MeetingMinutes.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objvgs_MeetingMinutesEN.Month = objDT.Rows[0][convgs_MeetingMinutes.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objvgs_MeetingMinutesEN.Memo = objDT.Rows[0][convgs_MeetingMinutes.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_MeetingMinutesEN.VersionCount = TransNullToInt(objDT.Rows[0][convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_MeetingMinutesEN.Participants = objDT.Rows[0][convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_MeetingMinutesEN.IdCurrEduCls = objDT.Rows[0][convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvgs_MeetingMinutesDA: Getvgs_MeetingMinutes)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMeetingId">表关键字</param>
 /// <returns>表对象</returns>
public clsvgs_MeetingMinutesEN GetObjByMeetingId(string strMeetingId)
{
CheckPrimaryKey(strMeetingId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from vgs_MeetingMinutes where MeetingId = " + "'"+ strMeetingId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
 objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id(字段类型:char,字段长度:10,是否可空:False)
 objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者(字段类型:varchar,字段长度:500,是否可空:True)
 objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvgs_MeetingMinutesDA: GetObjByMeetingId)", objException.Message));
}
return objvgs_MeetingMinutesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvgs_MeetingMinutesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from vgs_MeetingMinutes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN()
{
MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(), //会议Id
TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(), //主题Id
IsSubmit = TransNullToBool(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()), //是否提交
TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(), //栏目主题
MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(), //会议内容
MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(), //会议日期
UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(), //修改人
Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(), //年
Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(), //月
Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(), //备注
VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()), //版本统计
Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(), //参会者
IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objvgs_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_MeetingMinutesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvgs_MeetingMinutesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvgs_MeetingMinutesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = TransNullToBool(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvgs_MeetingMinutesDA: GetObjByDataRowvgs_MeetingMinutes)", objException.Message));
}
objvgs_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_MeetingMinutesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvgs_MeetingMinutesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = TransNullToBool(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvgs_MeetingMinutesDA: GetObjByDataRow)", objException.Message));
}
objvgs_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvgs_MeetingMinutesEN;
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
objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_MeetingMinutesEN._CurrTabName, convgs_MeetingMinutes.MeetingId, 10, "");
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
objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvgs_MeetingMinutesEN._CurrTabName, convgs_MeetingMinutes.MeetingId, 10, strPrefix);
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
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MeetingId from vgs_MeetingMinutes where " + strCondition;
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
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MeetingId from vgs_MeetingMinutes where " + strCondition;
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
 /// <param name = "strMeetingId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMeetingId)
{
CheckPrimaryKey(strMeetingId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_MeetingMinutes", "MeetingId = " + "'"+ strMeetingId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvgs_MeetingMinutesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vgs_MeetingMinutes", strCondition))
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
objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vgs_MeetingMinutes");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesENS">源对象</param>
 /// <param name = "objvgs_MeetingMinutesENT">目标对象</param>
public void CopyTo(clsvgs_MeetingMinutesEN objvgs_MeetingMinutesENS, clsvgs_MeetingMinutesEN objvgs_MeetingMinutesENT)
{
objvgs_MeetingMinutesENT.MeetingId = objvgs_MeetingMinutesENS.MeetingId; //会议Id
objvgs_MeetingMinutesENT.TopicId = objvgs_MeetingMinutesENS.TopicId; //主题Id
objvgs_MeetingMinutesENT.IsSubmit = objvgs_MeetingMinutesENS.IsSubmit; //是否提交
objvgs_MeetingMinutesENT.TopicName = objvgs_MeetingMinutesENS.TopicName; //栏目主题
objvgs_MeetingMinutesENT.MeetingContent = objvgs_MeetingMinutesENS.MeetingContent; //会议内容
objvgs_MeetingMinutesENT.MeetingDate = objvgs_MeetingMinutesENS.MeetingDate; //会议日期
objvgs_MeetingMinutesENT.UpdDate = objvgs_MeetingMinutesENS.UpdDate; //修改日期
objvgs_MeetingMinutesENT.UpdUser = objvgs_MeetingMinutesENS.UpdUser; //修改人
objvgs_MeetingMinutesENT.Year = objvgs_MeetingMinutesENS.Year; //年
objvgs_MeetingMinutesENT.Month = objvgs_MeetingMinutesENS.Month; //月
objvgs_MeetingMinutesENT.Memo = objvgs_MeetingMinutesENS.Memo; //备注
objvgs_MeetingMinutesENT.VersionCount = objvgs_MeetingMinutesENS.VersionCount; //版本统计
objvgs_MeetingMinutesENT.Participants = objvgs_MeetingMinutesENS.Participants; //参会者
objvgs_MeetingMinutesENT.IdCurrEduCls = objvgs_MeetingMinutesENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.MeetingId, 10, convgs_MeetingMinutes.MeetingId);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.TopicId, 8, convgs_MeetingMinutes.TopicId);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.TopicName, 200, convgs_MeetingMinutes.TopicName);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.MeetingDate, 20, convgs_MeetingMinutes.MeetingDate);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.UpdDate, 20, convgs_MeetingMinutes.UpdDate);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.UpdUser, 20, convgs_MeetingMinutes.UpdUser);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.Year, 4, convgs_MeetingMinutes.Year);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.Month, 2, convgs_MeetingMinutes.Month);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.Memo, 1000, convgs_MeetingMinutes.Memo);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.Participants, 500, convgs_MeetingMinutes.Participants);
clsCheckSql.CheckFieldLen(objvgs_MeetingMinutesEN.IdCurrEduCls, 8, convgs_MeetingMinutes.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.MeetingId, convgs_MeetingMinutes.MeetingId);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.TopicId, convgs_MeetingMinutes.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.TopicName, convgs_MeetingMinutes.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.MeetingDate, convgs_MeetingMinutes.MeetingDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.UpdDate, convgs_MeetingMinutes.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.UpdUser, convgs_MeetingMinutes.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.Year, convgs_MeetingMinutes.Year);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.Month, convgs_MeetingMinutes.Month);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.Memo, convgs_MeetingMinutes.Memo);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.Participants, convgs_MeetingMinutes.Participants);
clsCheckSql.CheckSqlInjection4Field(objvgs_MeetingMinutesEN.IdCurrEduCls, convgs_MeetingMinutes.IdCurrEduCls);
//检查外键字段长度
 objvgs_MeetingMinutesEN._IsCheckProperty = true;
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
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
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
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
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
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_MeetingMinutesEN._CurrTabName);
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
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvgs_MeetingMinutesEN._CurrTabName, strCondition);
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
 objSQL = clsvgs_MeetingMinutesDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}