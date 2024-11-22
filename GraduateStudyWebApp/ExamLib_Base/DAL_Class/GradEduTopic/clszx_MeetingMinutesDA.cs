
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_MeetingMinutesDA
 表名:zx_MeetingMinutes(01120799)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:32
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
 /// 中学会议纪要(zx_MeetingMinutes)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_MeetingMinutesDA : clsCommBase4DA
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
 return clszx_MeetingMinutesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_MeetingMinutesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_MeetingMinutesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_MeetingMinutesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_MeetingMinutesEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxMeetingId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxMeetingId)
{
strzxMeetingId = strzxMeetingId.Replace("'", "''");
if (strzxMeetingId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:zx_MeetingMinutes中,检查关键字,长度不正确!(clszx_MeetingMinutesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxMeetingId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_MeetingMinutes中,关键字不能为空 或 null!(clszx_MeetingMinutesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxMeetingId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_MeetingMinutesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_MeetingMinutes(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTable_zx_MeetingMinutes)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_MeetingMinutes where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_MeetingMinutes where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_MeetingMinutes where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_MeetingMinutes.* from zx_MeetingMinutes Left Join {1} on {2} where {3} and zx_MeetingMinutes.zxMeetingId not in (Select top {5} zx_MeetingMinutes.zxMeetingId from zx_MeetingMinutes Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_MeetingMinutes where {1} and zxMeetingId not in (Select top {2} zxMeetingId from zx_MeetingMinutes where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_MeetingMinutes where {1} and zxMeetingId not in (Select top {3} zxMeetingId from zx_MeetingMinutes where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_MeetingMinutes.* from zx_MeetingMinutes Left Join {1} on {2} where {3} and zx_MeetingMinutes.zxMeetingId not in (Select top {5} zx_MeetingMinutes.zxMeetingId from zx_MeetingMinutes Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_MeetingMinutes where {1} and zxMeetingId not in (Select top {2} zxMeetingId from zx_MeetingMinutes where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_MeetingMinutes where {1} and zxMeetingId not in (Select top {3} zxMeetingId from zx_MeetingMinutes where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_MeetingMinutesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA:GetObjLst)", objException.Message));
}
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = TransNullToBool(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_MeetingMinutesDA: GetObjLst)", objException.Message));
}
objzx_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_MeetingMinutesEN);
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
public List<clszx_MeetingMinutesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = TransNullToBool(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_MeetingMinutesDA: GetObjLst)", objException.Message));
}
objzx_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_MeetingMinutes(ref clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where zxMeetingId = " + "'"+ objzx_MeetingMinutesEN.zxMeetingId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_MeetingMinutesEN.zxMeetingId = objDT.Rows[0][conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_MeetingMinutesEN.GroupTextId = objDT.Rows[0][conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_MeetingMinutesEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_MeetingMinutesEN.MeetingContent = objDT.Rows[0][conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_MeetingMinutesEN.MeetingDate = objDT.Rows[0][conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_MeetingMinutesEN.UpdDate = objDT.Rows[0][conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_MeetingMinutesEN.UpdUser = objDT.Rows[0][conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_MeetingMinutesEN.Year = objDT.Rows[0][conzx_MeetingMinutes.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objzx_MeetingMinutesEN.Month = objDT.Rows[0][conzx_MeetingMinutes.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objzx_MeetingMinutesEN.Memo = objDT.Rows[0][conzx_MeetingMinutes.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_MeetingMinutesEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_MeetingMinutesEN.Participants = objDT.Rows[0][conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_MeetingMinutesEN.IdCurrEduCls = objDT.Rows[0][conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_MeetingMinutesDA: Getzx_MeetingMinutes)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxMeetingId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_MeetingMinutesEN GetObjByzxMeetingId(string strzxMeetingId)
{
CheckPrimaryKey(strzxMeetingId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where zxMeetingId = " + "'"+ strzxMeetingId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
 objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_MeetingMinutesDA: GetObjByzxMeetingId)", objException.Message));
}
return objzx_MeetingMinutesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_MeetingMinutesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN()
{
zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(), //会议Id
GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(), //小组Id
IsSubmit = TransNullToBool(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()), //是否提交
MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(), //会议内容
MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(), //会议日期
UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(), //修改人
Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(), //年
Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(), //月
Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(), //备注
VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()), //版本统计
Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(), //参会者
IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objzx_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_MeetingMinutesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_MeetingMinutesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_MeetingMinutesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = TransNullToBool(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_MeetingMinutesDA: GetObjByDataRowzx_MeetingMinutes)", objException.Message));
}
objzx_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_MeetingMinutesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_MeetingMinutesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = TransNullToBool(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_MeetingMinutesDA: GetObjByDataRow)", objException.Message));
}
objzx_MeetingMinutesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_MeetingMinutesEN;
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
objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_MeetingMinutesEN._CurrTabName, conzx_MeetingMinutes.zxMeetingId, 10, "");
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
objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_MeetingMinutesEN._CurrTabName, conzx_MeetingMinutes.zxMeetingId, 10, strPrefix);
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
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxMeetingId from zx_MeetingMinutes where " + strCondition;
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
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxMeetingId from zx_MeetingMinutes where " + strCondition;
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
 /// <param name = "strzxMeetingId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxMeetingId)
{
CheckPrimaryKey(strzxMeetingId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_MeetingMinutes", "zxMeetingId = " + "'"+ strzxMeetingId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_MeetingMinutes", strCondition))
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
objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_MeetingMinutes");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
 {
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_MeetingMinutesEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_MeetingMinutes");
objRow = objDS.Tables["zx_MeetingMinutes"].NewRow();
objRow[conzx_MeetingMinutes.zxMeetingId] = objzx_MeetingMinutesEN.zxMeetingId; //会议Id
 if (objzx_MeetingMinutesEN.GroupTextId !=  "")
 {
objRow[conzx_MeetingMinutes.GroupTextId] = objzx_MeetingMinutesEN.GroupTextId; //小组Id
 }
objRow[conzx_MeetingMinutes.IsSubmit] = objzx_MeetingMinutesEN.IsSubmit; //是否提交
 if (objzx_MeetingMinutesEN.MeetingContent !=  "")
 {
objRow[conzx_MeetingMinutes.MeetingContent] = objzx_MeetingMinutesEN.MeetingContent; //会议内容
 }
 if (objzx_MeetingMinutesEN.MeetingDate !=  "")
 {
objRow[conzx_MeetingMinutes.MeetingDate] = objzx_MeetingMinutesEN.MeetingDate; //会议日期
 }
 if (objzx_MeetingMinutesEN.UpdDate !=  "")
 {
objRow[conzx_MeetingMinutes.UpdDate] = objzx_MeetingMinutesEN.UpdDate; //修改日期
 }
 if (objzx_MeetingMinutesEN.UpdUser !=  "")
 {
objRow[conzx_MeetingMinutes.UpdUser] = objzx_MeetingMinutesEN.UpdUser; //修改人
 }
 if (objzx_MeetingMinutesEN.Year !=  "")
 {
objRow[conzx_MeetingMinutes.Year] = objzx_MeetingMinutesEN.Year; //年
 }
 if (objzx_MeetingMinutesEN.Month !=  "")
 {
objRow[conzx_MeetingMinutes.Month] = objzx_MeetingMinutesEN.Month; //月
 }
 if (objzx_MeetingMinutesEN.Memo !=  "")
 {
objRow[conzx_MeetingMinutes.Memo] = objzx_MeetingMinutesEN.Memo; //备注
 }
objRow[conzx_MeetingMinutes.VersionCount] = objzx_MeetingMinutesEN.VersionCount; //版本统计
 if (objzx_MeetingMinutesEN.Participants !=  "")
 {
objRow[conzx_MeetingMinutes.Participants] = objzx_MeetingMinutesEN.Participants; //参会者
 }
objRow[conzx_MeetingMinutes.IdCurrEduCls] = objzx_MeetingMinutesEN.IdCurrEduCls; //教学班流水号
objDS.Tables[clszx_MeetingMinutesEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_MeetingMinutesEN._CurrTabName);
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_MeetingMinutesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_MeetingMinutesEN.zxMeetingId !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.zxMeetingId);
 var strzxMeetingId = objzx_MeetingMinutesEN.zxMeetingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxMeetingId + "'");
 }
 
 if (objzx_MeetingMinutesEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.GroupTextId);
 var strGroupTextId = objzx_MeetingMinutesEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_MeetingMinutes.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_MeetingMinutesEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_MeetingMinutesEN.MeetingContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.MeetingContent);
 var strMeetingContent = objzx_MeetingMinutesEN.MeetingContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMeetingContent + "'");
 }
 
 if (objzx_MeetingMinutesEN.MeetingDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.MeetingDate);
 var strMeetingDate = objzx_MeetingMinutesEN.MeetingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMeetingDate + "'");
 }
 
 if (objzx_MeetingMinutesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.UpdDate);
 var strUpdDate = objzx_MeetingMinutesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_MeetingMinutesEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.UpdUser);
 var strUpdUser = objzx_MeetingMinutesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_MeetingMinutesEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Year);
 var strYear = objzx_MeetingMinutesEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_MeetingMinutesEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Month);
 var strMonth = objzx_MeetingMinutesEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_MeetingMinutesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Memo);
 var strMemo = objzx_MeetingMinutesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_MeetingMinutesEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.VersionCount);
 arrValueListForInsert.Add(objzx_MeetingMinutesEN.VersionCount.ToString());
 }
 
 if (objzx_MeetingMinutesEN.Participants !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Participants);
 var strParticipants = objzx_MeetingMinutesEN.Participants.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipants + "'");
 }
 
 if (objzx_MeetingMinutesEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.IdCurrEduCls);
 var strIdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_MeetingMinutes");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_MeetingMinutesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_MeetingMinutesEN.zxMeetingId !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.zxMeetingId);
 var strzxMeetingId = objzx_MeetingMinutesEN.zxMeetingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxMeetingId + "'");
 }
 
 if (objzx_MeetingMinutesEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.GroupTextId);
 var strGroupTextId = objzx_MeetingMinutesEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_MeetingMinutes.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_MeetingMinutesEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_MeetingMinutesEN.MeetingContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.MeetingContent);
 var strMeetingContent = objzx_MeetingMinutesEN.MeetingContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMeetingContent + "'");
 }
 
 if (objzx_MeetingMinutesEN.MeetingDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.MeetingDate);
 var strMeetingDate = objzx_MeetingMinutesEN.MeetingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMeetingDate + "'");
 }
 
 if (objzx_MeetingMinutesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.UpdDate);
 var strUpdDate = objzx_MeetingMinutesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_MeetingMinutesEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.UpdUser);
 var strUpdUser = objzx_MeetingMinutesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_MeetingMinutesEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Year);
 var strYear = objzx_MeetingMinutesEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_MeetingMinutesEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Month);
 var strMonth = objzx_MeetingMinutesEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_MeetingMinutesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Memo);
 var strMemo = objzx_MeetingMinutesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_MeetingMinutesEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.VersionCount);
 arrValueListForInsert.Add(objzx_MeetingMinutesEN.VersionCount.ToString());
 }
 
 if (objzx_MeetingMinutesEN.Participants !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Participants);
 var strParticipants = objzx_MeetingMinutesEN.Participants.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipants + "'");
 }
 
 if (objzx_MeetingMinutesEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.IdCurrEduCls);
 var strIdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_MeetingMinutes");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_MeetingMinutesEN.zxMeetingId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_MeetingMinutesEN objzx_MeetingMinutesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_MeetingMinutesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_MeetingMinutesEN.zxMeetingId !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.zxMeetingId);
 var strzxMeetingId = objzx_MeetingMinutesEN.zxMeetingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxMeetingId + "'");
 }
 
 if (objzx_MeetingMinutesEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.GroupTextId);
 var strGroupTextId = objzx_MeetingMinutesEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_MeetingMinutes.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_MeetingMinutesEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_MeetingMinutesEN.MeetingContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.MeetingContent);
 var strMeetingContent = objzx_MeetingMinutesEN.MeetingContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMeetingContent + "'");
 }
 
 if (objzx_MeetingMinutesEN.MeetingDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.MeetingDate);
 var strMeetingDate = objzx_MeetingMinutesEN.MeetingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMeetingDate + "'");
 }
 
 if (objzx_MeetingMinutesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.UpdDate);
 var strUpdDate = objzx_MeetingMinutesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_MeetingMinutesEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.UpdUser);
 var strUpdUser = objzx_MeetingMinutesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_MeetingMinutesEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Year);
 var strYear = objzx_MeetingMinutesEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_MeetingMinutesEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Month);
 var strMonth = objzx_MeetingMinutesEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_MeetingMinutesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Memo);
 var strMemo = objzx_MeetingMinutesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_MeetingMinutesEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.VersionCount);
 arrValueListForInsert.Add(objzx_MeetingMinutesEN.VersionCount.ToString());
 }
 
 if (objzx_MeetingMinutesEN.Participants !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Participants);
 var strParticipants = objzx_MeetingMinutesEN.Participants.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipants + "'");
 }
 
 if (objzx_MeetingMinutesEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.IdCurrEduCls);
 var strIdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_MeetingMinutes");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_MeetingMinutesEN.zxMeetingId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_MeetingMinutesEN objzx_MeetingMinutesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_MeetingMinutesEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_MeetingMinutesEN.zxMeetingId !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.zxMeetingId);
 var strzxMeetingId = objzx_MeetingMinutesEN.zxMeetingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxMeetingId + "'");
 }
 
 if (objzx_MeetingMinutesEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.GroupTextId);
 var strGroupTextId = objzx_MeetingMinutesEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_MeetingMinutes.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_MeetingMinutesEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_MeetingMinutesEN.MeetingContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.MeetingContent);
 var strMeetingContent = objzx_MeetingMinutesEN.MeetingContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMeetingContent + "'");
 }
 
 if (objzx_MeetingMinutesEN.MeetingDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.MeetingDate);
 var strMeetingDate = objzx_MeetingMinutesEN.MeetingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMeetingDate + "'");
 }
 
 if (objzx_MeetingMinutesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.UpdDate);
 var strUpdDate = objzx_MeetingMinutesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_MeetingMinutesEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.UpdUser);
 var strUpdUser = objzx_MeetingMinutesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_MeetingMinutesEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Year);
 var strYear = objzx_MeetingMinutesEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_MeetingMinutesEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Month);
 var strMonth = objzx_MeetingMinutesEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_MeetingMinutesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Memo);
 var strMemo = objzx_MeetingMinutesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_MeetingMinutesEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.VersionCount);
 arrValueListForInsert.Add(objzx_MeetingMinutesEN.VersionCount.ToString());
 }
 
 if (objzx_MeetingMinutesEN.Participants !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.Participants);
 var strParticipants = objzx_MeetingMinutesEN.Participants.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipants + "'");
 }
 
 if (objzx_MeetingMinutesEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_MeetingMinutes.IdCurrEduCls);
 var strIdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_MeetingMinutes");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_MeetingMinutess(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where zxMeetingId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_MeetingMinutes");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxMeetingId = oRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim();
if (IsExist(strzxMeetingId))
{
 string strResult = "关键字变量值为:" + string.Format("zxMeetingId = {0}", strzxMeetingId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_MeetingMinutesEN._CurrTabName ].NewRow();
objRow[conzx_MeetingMinutes.zxMeetingId] = oRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objRow[conzx_MeetingMinutes.GroupTextId] = oRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objRow[conzx_MeetingMinutes.IsSubmit] = oRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_MeetingMinutes.MeetingContent] = oRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objRow[conzx_MeetingMinutes.MeetingDate] = oRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objRow[conzx_MeetingMinutes.UpdDate] = oRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_MeetingMinutes.UpdUser] = oRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objRow[conzx_MeetingMinutes.Year] = oRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objRow[conzx_MeetingMinutes.Month] = oRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objRow[conzx_MeetingMinutes.Memo] = oRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objRow[conzx_MeetingMinutes.VersionCount] = oRow[conzx_MeetingMinutes.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_MeetingMinutes.Participants] = oRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objRow[conzx_MeetingMinutes.IdCurrEduCls] = oRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
 objDS.Tables[clszx_MeetingMinutesEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_MeetingMinutesEN._CurrTabName);
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
 /// <param name = "objzx_MeetingMinutesEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_MeetingMinutesEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
strSQL = "Select * from zx_MeetingMinutes where zxMeetingId = " + "'"+ objzx_MeetingMinutesEN.zxMeetingId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_MeetingMinutesEN._CurrTabName);
if (objDS.Tables[clszx_MeetingMinutesEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxMeetingId = " + "'"+ objzx_MeetingMinutesEN.zxMeetingId+"'");
return false;
}
objRow = objDS.Tables[clszx_MeetingMinutesEN._CurrTabName].Rows[0];
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.zxMeetingId))
 {
objRow[conzx_MeetingMinutes.zxMeetingId] = objzx_MeetingMinutesEN.zxMeetingId; //会议Id
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.GroupTextId))
 {
objRow[conzx_MeetingMinutes.GroupTextId] = objzx_MeetingMinutesEN.GroupTextId; //小组Id
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IsSubmit))
 {
objRow[conzx_MeetingMinutes.IsSubmit] = objzx_MeetingMinutesEN.IsSubmit; //是否提交
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingContent))
 {
objRow[conzx_MeetingMinutes.MeetingContent] = objzx_MeetingMinutesEN.MeetingContent; //会议内容
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingDate))
 {
objRow[conzx_MeetingMinutes.MeetingDate] = objzx_MeetingMinutesEN.MeetingDate; //会议日期
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdDate))
 {
objRow[conzx_MeetingMinutes.UpdDate] = objzx_MeetingMinutesEN.UpdDate; //修改日期
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdUser))
 {
objRow[conzx_MeetingMinutes.UpdUser] = objzx_MeetingMinutesEN.UpdUser; //修改人
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Year))
 {
objRow[conzx_MeetingMinutes.Year] = objzx_MeetingMinutesEN.Year; //年
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Month))
 {
objRow[conzx_MeetingMinutes.Month] = objzx_MeetingMinutesEN.Month; //月
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Memo))
 {
objRow[conzx_MeetingMinutes.Memo] = objzx_MeetingMinutesEN.Memo; //备注
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.VersionCount))
 {
objRow[conzx_MeetingMinutes.VersionCount] = objzx_MeetingMinutesEN.VersionCount; //版本统计
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Participants))
 {
objRow[conzx_MeetingMinutes.Participants] = objzx_MeetingMinutesEN.Participants; //参会者
 }
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IdCurrEduCls))
 {
objRow[conzx_MeetingMinutes.IdCurrEduCls] = objzx_MeetingMinutesEN.IdCurrEduCls; //教学班流水号
 }
try
{
objDA.Update(objDS, clszx_MeetingMinutesEN._CurrTabName);
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_MeetingMinutesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_MeetingMinutes Set ");
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.GroupTextId))
 {
 if (objzx_MeetingMinutesEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_MeetingMinutesEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_MeetingMinutes.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.GroupTextId); //小组Id
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_MeetingMinutesEN.IsSubmit == true?"1":"0", conzx_MeetingMinutes.IsSubmit); //是否提交
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingContent))
 {
 if (objzx_MeetingMinutesEN.MeetingContent !=  null)
 {
 var strMeetingContent = objzx_MeetingMinutesEN.MeetingContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMeetingContent, conzx_MeetingMinutes.MeetingContent); //会议内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.MeetingContent); //会议内容
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingDate))
 {
 if (objzx_MeetingMinutesEN.MeetingDate !=  null)
 {
 var strMeetingDate = objzx_MeetingMinutesEN.MeetingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMeetingDate, conzx_MeetingMinutes.MeetingDate); //会议日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.MeetingDate); //会议日期
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdDate))
 {
 if (objzx_MeetingMinutesEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_MeetingMinutesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_MeetingMinutes.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.UpdDate); //修改日期
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdUser))
 {
 if (objzx_MeetingMinutesEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_MeetingMinutesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_MeetingMinutes.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.UpdUser); //修改人
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Year))
 {
 if (objzx_MeetingMinutesEN.Year !=  null)
 {
 var strYear = objzx_MeetingMinutesEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, conzx_MeetingMinutes.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.Year); //年
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Month))
 {
 if (objzx_MeetingMinutesEN.Month !=  null)
 {
 var strMonth = objzx_MeetingMinutesEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, conzx_MeetingMinutes.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.Month); //月
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Memo))
 {
 if (objzx_MeetingMinutesEN.Memo !=  null)
 {
 var strMemo = objzx_MeetingMinutesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_MeetingMinutes.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.Memo); //备注
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.VersionCount))
 {
 if (objzx_MeetingMinutesEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_MeetingMinutesEN.VersionCount, conzx_MeetingMinutes.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.VersionCount); //版本统计
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Participants))
 {
 if (objzx_MeetingMinutesEN.Participants !=  null)
 {
 var strParticipants = objzx_MeetingMinutesEN.Participants.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipants, conzx_MeetingMinutes.Participants); //参会者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.Participants); //参会者
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IdCurrEduCls))
 {
 if (objzx_MeetingMinutesEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_MeetingMinutes.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxMeetingId = '{0}'", objzx_MeetingMinutesEN.zxMeetingId); 
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
 /// <param name = "objzx_MeetingMinutesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strCondition)
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_MeetingMinutesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_MeetingMinutes Set ");
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.GroupTextId))
 {
 if (objzx_MeetingMinutesEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_MeetingMinutesEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_MeetingMinutesEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingContent))
 {
 if (objzx_MeetingMinutesEN.MeetingContent !=  null)
 {
 var strMeetingContent = objzx_MeetingMinutesEN.MeetingContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MeetingContent = '{0}',", strMeetingContent); //会议内容
 }
 else
 {
 sbSQL.Append(" MeetingContent = null,"); //会议内容
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingDate))
 {
 if (objzx_MeetingMinutesEN.MeetingDate !=  null)
 {
 var strMeetingDate = objzx_MeetingMinutesEN.MeetingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MeetingDate = '{0}',", strMeetingDate); //会议日期
 }
 else
 {
 sbSQL.Append(" MeetingDate = null,"); //会议日期
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdDate))
 {
 if (objzx_MeetingMinutesEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_MeetingMinutesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdUser))
 {
 if (objzx_MeetingMinutesEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_MeetingMinutesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Year))
 {
 if (objzx_MeetingMinutesEN.Year !=  null)
 {
 var strYear = objzx_MeetingMinutesEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Month))
 {
 if (objzx_MeetingMinutesEN.Month !=  null)
 {
 var strMonth = objzx_MeetingMinutesEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Memo))
 {
 if (objzx_MeetingMinutesEN.Memo !=  null)
 {
 var strMemo = objzx_MeetingMinutesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.VersionCount))
 {
 if (objzx_MeetingMinutesEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_MeetingMinutesEN.VersionCount, conzx_MeetingMinutes.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.VersionCount); //版本统计
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Participants))
 {
 if (objzx_MeetingMinutesEN.Participants !=  null)
 {
 var strParticipants = objzx_MeetingMinutesEN.Participants.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participants = '{0}',", strParticipants); //参会者
 }
 else
 {
 sbSQL.Append(" Participants = null,"); //参会者
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IdCurrEduCls))
 {
 if (objzx_MeetingMinutesEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objzx_MeetingMinutesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_MeetingMinutesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_MeetingMinutes Set ");
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.GroupTextId))
 {
 if (objzx_MeetingMinutesEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_MeetingMinutesEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_MeetingMinutesEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingContent))
 {
 if (objzx_MeetingMinutesEN.MeetingContent !=  null)
 {
 var strMeetingContent = objzx_MeetingMinutesEN.MeetingContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MeetingContent = '{0}',", strMeetingContent); //会议内容
 }
 else
 {
 sbSQL.Append(" MeetingContent = null,"); //会议内容
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingDate))
 {
 if (objzx_MeetingMinutesEN.MeetingDate !=  null)
 {
 var strMeetingDate = objzx_MeetingMinutesEN.MeetingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MeetingDate = '{0}',", strMeetingDate); //会议日期
 }
 else
 {
 sbSQL.Append(" MeetingDate = null,"); //会议日期
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdDate))
 {
 if (objzx_MeetingMinutesEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_MeetingMinutesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdUser))
 {
 if (objzx_MeetingMinutesEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_MeetingMinutesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Year))
 {
 if (objzx_MeetingMinutesEN.Year !=  null)
 {
 var strYear = objzx_MeetingMinutesEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Month))
 {
 if (objzx_MeetingMinutesEN.Month !=  null)
 {
 var strMonth = objzx_MeetingMinutesEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Memo))
 {
 if (objzx_MeetingMinutesEN.Memo !=  null)
 {
 var strMemo = objzx_MeetingMinutesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.VersionCount))
 {
 if (objzx_MeetingMinutesEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_MeetingMinutesEN.VersionCount, conzx_MeetingMinutes.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.VersionCount); //版本统计
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Participants))
 {
 if (objzx_MeetingMinutesEN.Participants !=  null)
 {
 var strParticipants = objzx_MeetingMinutesEN.Participants.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participants = '{0}',", strParticipants); //参会者
 }
 else
 {
 sbSQL.Append(" Participants = null,"); //参会者
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IdCurrEduCls))
 {
 if (objzx_MeetingMinutesEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_MeetingMinutesEN objzx_MeetingMinutesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_MeetingMinutesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_MeetingMinutesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_MeetingMinutes Set ");
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.GroupTextId))
 {
 if (objzx_MeetingMinutesEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_MeetingMinutesEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_MeetingMinutes.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.GroupTextId); //小组Id
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_MeetingMinutesEN.IsSubmit == true?"1":"0", conzx_MeetingMinutes.IsSubmit); //是否提交
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingContent))
 {
 if (objzx_MeetingMinutesEN.MeetingContent !=  null)
 {
 var strMeetingContent = objzx_MeetingMinutesEN.MeetingContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMeetingContent, conzx_MeetingMinutes.MeetingContent); //会议内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.MeetingContent); //会议内容
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.MeetingDate))
 {
 if (objzx_MeetingMinutesEN.MeetingDate !=  null)
 {
 var strMeetingDate = objzx_MeetingMinutesEN.MeetingDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMeetingDate, conzx_MeetingMinutes.MeetingDate); //会议日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.MeetingDate); //会议日期
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdDate))
 {
 if (objzx_MeetingMinutesEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_MeetingMinutesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_MeetingMinutes.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.UpdDate); //修改日期
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.UpdUser))
 {
 if (objzx_MeetingMinutesEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_MeetingMinutesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_MeetingMinutes.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.UpdUser); //修改人
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Year))
 {
 if (objzx_MeetingMinutesEN.Year !=  null)
 {
 var strYear = objzx_MeetingMinutesEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, conzx_MeetingMinutes.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.Year); //年
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Month))
 {
 if (objzx_MeetingMinutesEN.Month !=  null)
 {
 var strMonth = objzx_MeetingMinutesEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, conzx_MeetingMinutes.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.Month); //月
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Memo))
 {
 if (objzx_MeetingMinutesEN.Memo !=  null)
 {
 var strMemo = objzx_MeetingMinutesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_MeetingMinutes.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.Memo); //备注
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.VersionCount))
 {
 if (objzx_MeetingMinutesEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_MeetingMinutesEN.VersionCount, conzx_MeetingMinutes.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.VersionCount); //版本统计
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.Participants))
 {
 if (objzx_MeetingMinutesEN.Participants !=  null)
 {
 var strParticipants = objzx_MeetingMinutesEN.Participants.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipants, conzx_MeetingMinutes.Participants); //参会者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.Participants); //参会者
 }
 }
 
 if (objzx_MeetingMinutesEN.IsUpdated(conzx_MeetingMinutes.IdCurrEduCls))
 {
 if (objzx_MeetingMinutesEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_MeetingMinutes.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_MeetingMinutes.IdCurrEduCls); //教学班流水号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxMeetingId = '{0}'", objzx_MeetingMinutesEN.zxMeetingId); 
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
 /// <param name = "strzxMeetingId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxMeetingId) 
{
CheckPrimaryKey(strzxMeetingId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxMeetingId,
};
 objSQL.ExecSP("zx_MeetingMinutes_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxMeetingId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxMeetingId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxMeetingId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
//删除zx_MeetingMinutes本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_MeetingMinutes where zxMeetingId = " + "'"+ strzxMeetingId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_MeetingMinutes(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
//删除zx_MeetingMinutes本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_MeetingMinutes where zxMeetingId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxMeetingId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxMeetingId) 
{
CheckPrimaryKey(strzxMeetingId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
//删除zx_MeetingMinutes本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_MeetingMinutes where zxMeetingId = " + "'"+ strzxMeetingId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_MeetingMinutes(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: Delzx_MeetingMinutes)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_MeetingMinutes where " + strCondition ;
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
public bool Delzx_MeetingMinutesWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_MeetingMinutesDA: Delzx_MeetingMinutesWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_MeetingMinutes where " + strCondition ;
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
 /// <param name = "objzx_MeetingMinutesENS">源对象</param>
 /// <param name = "objzx_MeetingMinutesENT">目标对象</param>
public void CopyTo(clszx_MeetingMinutesEN objzx_MeetingMinutesENS, clszx_MeetingMinutesEN objzx_MeetingMinutesENT)
{
objzx_MeetingMinutesENT.zxMeetingId = objzx_MeetingMinutesENS.zxMeetingId; //会议Id
objzx_MeetingMinutesENT.GroupTextId = objzx_MeetingMinutesENS.GroupTextId; //小组Id
objzx_MeetingMinutesENT.IsSubmit = objzx_MeetingMinutesENS.IsSubmit; //是否提交
objzx_MeetingMinutesENT.MeetingContent = objzx_MeetingMinutesENS.MeetingContent; //会议内容
objzx_MeetingMinutesENT.MeetingDate = objzx_MeetingMinutesENS.MeetingDate; //会议日期
objzx_MeetingMinutesENT.UpdDate = objzx_MeetingMinutesENS.UpdDate; //修改日期
objzx_MeetingMinutesENT.UpdUser = objzx_MeetingMinutesENS.UpdUser; //修改人
objzx_MeetingMinutesENT.Year = objzx_MeetingMinutesENS.Year; //年
objzx_MeetingMinutesENT.Month = objzx_MeetingMinutesENS.Month; //月
objzx_MeetingMinutesENT.Memo = objzx_MeetingMinutesENS.Memo; //备注
objzx_MeetingMinutesENT.VersionCount = objzx_MeetingMinutesENS.VersionCount; //版本统计
objzx_MeetingMinutesENT.Participants = objzx_MeetingMinutesENS.Participants; //参会者
objzx_MeetingMinutesENT.IdCurrEduCls = objzx_MeetingMinutesENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_MeetingMinutesEN.IdCurrEduCls, conzx_MeetingMinutes.IdCurrEduCls);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.zxMeetingId, 10, conzx_MeetingMinutes.zxMeetingId);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.GroupTextId, 8, conzx_MeetingMinutes.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.MeetingDate, 20, conzx_MeetingMinutes.MeetingDate);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.UpdDate, 20, conzx_MeetingMinutes.UpdDate);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.UpdUser, 20, conzx_MeetingMinutes.UpdUser);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Year, 4, conzx_MeetingMinutes.Year);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Month, 2, conzx_MeetingMinutes.Month);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Memo, 1000, conzx_MeetingMinutes.Memo);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Participants, 500, conzx_MeetingMinutes.Participants);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.IdCurrEduCls, 8, conzx_MeetingMinutes.IdCurrEduCls);
//检查字段外键固定长度
 objzx_MeetingMinutesEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.GroupTextId, 8, conzx_MeetingMinutes.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.MeetingDate, 20, conzx_MeetingMinutes.MeetingDate);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.UpdDate, 20, conzx_MeetingMinutes.UpdDate);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.UpdUser, 20, conzx_MeetingMinutes.UpdUser);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Year, 4, conzx_MeetingMinutes.Year);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Month, 2, conzx_MeetingMinutes.Month);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Memo, 1000, conzx_MeetingMinutes.Memo);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Participants, 500, conzx_MeetingMinutes.Participants);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.IdCurrEduCls, 8, conzx_MeetingMinutes.IdCurrEduCls);
//检查外键字段长度
 objzx_MeetingMinutesEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.zxMeetingId, 10, conzx_MeetingMinutes.zxMeetingId);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.GroupTextId, 8, conzx_MeetingMinutes.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.MeetingDate, 20, conzx_MeetingMinutes.MeetingDate);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.UpdDate, 20, conzx_MeetingMinutes.UpdDate);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.UpdUser, 20, conzx_MeetingMinutes.UpdUser);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Year, 4, conzx_MeetingMinutes.Year);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Month, 2, conzx_MeetingMinutes.Month);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Memo, 1000, conzx_MeetingMinutes.Memo);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.Participants, 500, conzx_MeetingMinutes.Participants);
clsCheckSql.CheckFieldLen(objzx_MeetingMinutesEN.IdCurrEduCls, 8, conzx_MeetingMinutes.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.zxMeetingId, conzx_MeetingMinutes.zxMeetingId);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.GroupTextId, conzx_MeetingMinutes.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.MeetingDate, conzx_MeetingMinutes.MeetingDate);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.UpdDate, conzx_MeetingMinutes.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.UpdUser, conzx_MeetingMinutes.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.Year, conzx_MeetingMinutes.Year);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.Month, conzx_MeetingMinutes.Month);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.Memo, conzx_MeetingMinutes.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.Participants, conzx_MeetingMinutes.Participants);
clsCheckSql.CheckSqlInjection4Field(objzx_MeetingMinutesEN.IdCurrEduCls, conzx_MeetingMinutes.IdCurrEduCls);
//检查外键字段长度
 objzx_MeetingMinutesEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_MeetingMinutes(中学会议纪要),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_MeetingMinutesEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null");
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_MeetingMinutesEN.GroupTextId);
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
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_MeetingMinutesEN._CurrTabName);
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
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_MeetingMinutesEN._CurrTabName, strCondition);
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
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
 objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}