
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsShortMessageDA
 表名:ShortMessage(01120286)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
 /// 短信消息(ShortMessage)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsShortMessageDA : clsCommBase4DA
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
 return clsShortMessageEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsShortMessageEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsShortMessageEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsShortMessageEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsShortMessageEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ShortMessage(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTable_ShortMessage)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ShortMessage where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ShortMessage where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ShortMessage where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ShortMessage.* from ShortMessage Left Join {1} on {2} where {3} and ShortMessage.ShortMessageId not in (Select top {5} ShortMessage.ShortMessageId from ShortMessage Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ShortMessage where {1} and ShortMessageId not in (Select top {2} ShortMessageId from ShortMessage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ShortMessage where {1} and ShortMessageId not in (Select top {3} ShortMessageId from ShortMessage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsShortMessageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ShortMessage.* from ShortMessage Left Join {1} on {2} where {3} and ShortMessage.ShortMessageId not in (Select top {5} ShortMessage.ShortMessageId from ShortMessage Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ShortMessage where {1} and ShortMessageId not in (Select top {2} ShortMessageId from ShortMessage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ShortMessage where {1} and ShortMessageId not in (Select top {3} ShortMessageId from ShortMessage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsShortMessageEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsShortMessageDA:GetObjLst)", objException.Message));
}
List<clsShortMessageEN> arrObjLst = new List<clsShortMessageEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsShortMessageEN objShortMessageEN = new clsShortMessageEN();
try
{
objShortMessageEN.ShortMessageId = TransNullToInt(objRow[conShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objShortMessageEN.MessageNumber = objRow[conShortMessage.MessageNumber] == DBNull.Value ? null : objRow[conShortMessage.MessageNumber].ToString().Trim(); //消息编号
objShortMessageEN.SendMessageNumber = objRow[conShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[conShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objShortMessageEN.Phone = objRow[conShortMessage.Phone] == DBNull.Value ? null : objRow[conShortMessage.Phone].ToString().Trim(); //手机号
objShortMessageEN.MessageContent = objRow[conShortMessage.MessageContent] == DBNull.Value ? null : objRow[conShortMessage.MessageContent].ToString().Trim(); //消息内容
objShortMessageEN.ShortMessageSendSateID = objRow[conShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objShortMessageEN.ReseiveState = TransNullToBool(objRow[conShortMessage.ReseiveState].ToString().Trim()); //接收状态
objShortMessageEN.ReturnTime = objRow[conShortMessage.ReturnTime] == DBNull.Value ? null : objRow[conShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objShortMessageEN.Memo = objRow[conShortMessage.Memo] == DBNull.Value ? null : objRow[conShortMessage.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsShortMessageDA: GetObjLst)", objException.Message));
}
objShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objShortMessageEN);
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
public List<clsShortMessageEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsShortMessageDA:GetObjLstByTabName)", objException.Message));
}
List<clsShortMessageEN> arrObjLst = new List<clsShortMessageEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsShortMessageEN objShortMessageEN = new clsShortMessageEN();
try
{
objShortMessageEN.ShortMessageId = TransNullToInt(objRow[conShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objShortMessageEN.MessageNumber = objRow[conShortMessage.MessageNumber] == DBNull.Value ? null : objRow[conShortMessage.MessageNumber].ToString().Trim(); //消息编号
objShortMessageEN.SendMessageNumber = objRow[conShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[conShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objShortMessageEN.Phone = objRow[conShortMessage.Phone] == DBNull.Value ? null : objRow[conShortMessage.Phone].ToString().Trim(); //手机号
objShortMessageEN.MessageContent = objRow[conShortMessage.MessageContent] == DBNull.Value ? null : objRow[conShortMessage.MessageContent].ToString().Trim(); //消息内容
objShortMessageEN.ShortMessageSendSateID = objRow[conShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objShortMessageEN.ReseiveState = TransNullToBool(objRow[conShortMessage.ReseiveState].ToString().Trim()); //接收状态
objShortMessageEN.ReturnTime = objRow[conShortMessage.ReturnTime] == DBNull.Value ? null : objRow[conShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objShortMessageEN.Memo = objRow[conShortMessage.Memo] == DBNull.Value ? null : objRow[conShortMessage.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsShortMessageDA: GetObjLst)", objException.Message));
}
objShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objShortMessageEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objShortMessageEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetShortMessage(ref clsShortMessageEN objShortMessageEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where ShortMessageId = " + ""+ objShortMessageEN.ShortMessageId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objShortMessageEN.ShortMessageId = TransNullToInt(objDT.Rows[0][conShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id(字段类型:bigint,字段长度:8,是否可空:False)
 objShortMessageEN.MessageNumber = objDT.Rows[0][conShortMessage.MessageNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objShortMessageEN.SendMessageNumber = objDT.Rows[0][conShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objShortMessageEN.Phone = objDT.Rows[0][conShortMessage.Phone].ToString().Trim(); //手机号(字段类型:varchar,字段长度:200,是否可空:True)
 objShortMessageEN.MessageContent = objDT.Rows[0][conShortMessage.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objShortMessageEN.ShortMessageSendSateID = objDT.Rows[0][conShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id(字段类型:char,字段长度:8,是否可空:False)
 objShortMessageEN.ReseiveState = TransNullToBool(objDT.Rows[0][conShortMessage.ReseiveState].ToString().Trim()); //接收状态(字段类型:bit,字段长度:1,是否可空:True)
 objShortMessageEN.ReturnTime = objDT.Rows[0][conShortMessage.ReturnTime].ToString().Trim(); //状态返回时间(字段类型:varchar,字段长度:20,是否可空:True)
 objShortMessageEN.Memo = objDT.Rows[0][conShortMessage.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsShortMessageDA: GetShortMessage)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngShortMessageId">表关键字</param>
 /// <returns>表对象</returns>
public clsShortMessageEN GetObjByShortMessageId(long lngShortMessageId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where ShortMessageId = " + ""+ lngShortMessageId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsShortMessageEN objShortMessageEN = new clsShortMessageEN();
try
{
 objShortMessageEN.ShortMessageId = Int32.Parse(objRow[conShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id(字段类型:bigint,字段长度:8,是否可空:False)
 objShortMessageEN.MessageNumber = objRow[conShortMessage.MessageNumber] == DBNull.Value ? null : objRow[conShortMessage.MessageNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objShortMessageEN.SendMessageNumber = objRow[conShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[conShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objShortMessageEN.Phone = objRow[conShortMessage.Phone] == DBNull.Value ? null : objRow[conShortMessage.Phone].ToString().Trim(); //手机号(字段类型:varchar,字段长度:200,是否可空:True)
 objShortMessageEN.MessageContent = objRow[conShortMessage.MessageContent] == DBNull.Value ? null : objRow[conShortMessage.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objShortMessageEN.ShortMessageSendSateID = objRow[conShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id(字段类型:char,字段长度:8,是否可空:False)
 objShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[conShortMessage.ReseiveState].ToString().Trim()); //接收状态(字段类型:bit,字段长度:1,是否可空:True)
 objShortMessageEN.ReturnTime = objRow[conShortMessage.ReturnTime] == DBNull.Value ? null : objRow[conShortMessage.ReturnTime].ToString().Trim(); //状态返回时间(字段类型:varchar,字段长度:20,是否可空:True)
 objShortMessageEN.Memo = objRow[conShortMessage.Memo] == DBNull.Value ? null : objRow[conShortMessage.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsShortMessageDA: GetObjByShortMessageId)", objException.Message));
}
return objShortMessageEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsShortMessageEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsShortMessageDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsShortMessageEN objShortMessageEN = new clsShortMessageEN()
{
ShortMessageId = TransNullToInt(objRow[conShortMessage.ShortMessageId].ToString().Trim()), //短信消息Id
MessageNumber = objRow[conShortMessage.MessageNumber] == DBNull.Value ? null : objRow[conShortMessage.MessageNumber].ToString().Trim(), //消息编号
SendMessageNumber = objRow[conShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[conShortMessage.SendMessageNumber].ToString().Trim(), //发送消息编号
Phone = objRow[conShortMessage.Phone] == DBNull.Value ? null : objRow[conShortMessage.Phone].ToString().Trim(), //手机号
MessageContent = objRow[conShortMessage.MessageContent] == DBNull.Value ? null : objRow[conShortMessage.MessageContent].ToString().Trim(), //消息内容
ShortMessageSendSateID = objRow[conShortMessage.ShortMessageSendSateID].ToString().Trim(), //消息发送状态Id
ReseiveState = TransNullToBool(objRow[conShortMessage.ReseiveState].ToString().Trim()), //接收状态
ReturnTime = objRow[conShortMessage.ReturnTime] == DBNull.Value ? null : objRow[conShortMessage.ReturnTime].ToString().Trim(), //状态返回时间
Memo = objRow[conShortMessage.Memo] == DBNull.Value ? null : objRow[conShortMessage.Memo].ToString().Trim() //备注
};
objShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objShortMessageEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsShortMessageDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsShortMessageEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsShortMessageEN objShortMessageEN = new clsShortMessageEN();
try
{
objShortMessageEN.ShortMessageId = TransNullToInt(objRow[conShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objShortMessageEN.MessageNumber = objRow[conShortMessage.MessageNumber] == DBNull.Value ? null : objRow[conShortMessage.MessageNumber].ToString().Trim(); //消息编号
objShortMessageEN.SendMessageNumber = objRow[conShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[conShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objShortMessageEN.Phone = objRow[conShortMessage.Phone] == DBNull.Value ? null : objRow[conShortMessage.Phone].ToString().Trim(); //手机号
objShortMessageEN.MessageContent = objRow[conShortMessage.MessageContent] == DBNull.Value ? null : objRow[conShortMessage.MessageContent].ToString().Trim(); //消息内容
objShortMessageEN.ShortMessageSendSateID = objRow[conShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objShortMessageEN.ReseiveState = TransNullToBool(objRow[conShortMessage.ReseiveState].ToString().Trim()); //接收状态
objShortMessageEN.ReturnTime = objRow[conShortMessage.ReturnTime] == DBNull.Value ? null : objRow[conShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objShortMessageEN.Memo = objRow[conShortMessage.Memo] == DBNull.Value ? null : objRow[conShortMessage.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsShortMessageDA: GetObjByDataRowShortMessage)", objException.Message));
}
objShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objShortMessageEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsShortMessageEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsShortMessageEN objShortMessageEN = new clsShortMessageEN();
try
{
objShortMessageEN.ShortMessageId = TransNullToInt(objRow[conShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objShortMessageEN.MessageNumber = objRow[conShortMessage.MessageNumber] == DBNull.Value ? null : objRow[conShortMessage.MessageNumber].ToString().Trim(); //消息编号
objShortMessageEN.SendMessageNumber = objRow[conShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[conShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objShortMessageEN.Phone = objRow[conShortMessage.Phone] == DBNull.Value ? null : objRow[conShortMessage.Phone].ToString().Trim(); //手机号
objShortMessageEN.MessageContent = objRow[conShortMessage.MessageContent] == DBNull.Value ? null : objRow[conShortMessage.MessageContent].ToString().Trim(); //消息内容
objShortMessageEN.ShortMessageSendSateID = objRow[conShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objShortMessageEN.ReseiveState = TransNullToBool(objRow[conShortMessage.ReseiveState].ToString().Trim()); //接收状态
objShortMessageEN.ReturnTime = objRow[conShortMessage.ReturnTime] == DBNull.Value ? null : objRow[conShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objShortMessageEN.Memo = objRow[conShortMessage.Memo] == DBNull.Value ? null : objRow[conShortMessage.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsShortMessageDA: GetObjByDataRow)", objException.Message));
}
objShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objShortMessageEN;
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
objSQL = clsShortMessageDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsShortMessageEN._CurrTabName, conShortMessage.ShortMessageId, 8, "");
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
objSQL = clsShortMessageDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsShortMessageEN._CurrTabName, conShortMessage.ShortMessageId, 8, strPrefix);
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
 objSQL = clsShortMessageDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ShortMessageId from ShortMessage where " + strCondition;
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
 objSQL = clsShortMessageDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ShortMessageId from ShortMessage where " + strCondition;
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
 /// <param name = "lngShortMessageId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngShortMessageId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ShortMessage", "ShortMessageId = " + ""+ lngShortMessageId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsShortMessageDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ShortMessage", strCondition))
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
objSQL = clsShortMessageDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ShortMessage");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsShortMessageEN objShortMessageEN)
 {
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objShortMessageEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ShortMessage");
objRow = objDS.Tables["ShortMessage"].NewRow();
 if (objShortMessageEN.MessageNumber !=  "")
 {
objRow[conShortMessage.MessageNumber] = objShortMessageEN.MessageNumber; //消息编号
 }
 if (objShortMessageEN.SendMessageNumber !=  "")
 {
objRow[conShortMessage.SendMessageNumber] = objShortMessageEN.SendMessageNumber; //发送消息编号
 }
 if (objShortMessageEN.Phone !=  "")
 {
objRow[conShortMessage.Phone] = objShortMessageEN.Phone; //手机号
 }
 if (objShortMessageEN.MessageContent !=  "")
 {
objRow[conShortMessage.MessageContent] = objShortMessageEN.MessageContent; //消息内容
 }
objRow[conShortMessage.ShortMessageSendSateID] = objShortMessageEN.ShortMessageSendSateID; //消息发送状态Id
objRow[conShortMessage.ReseiveState] = objShortMessageEN.ReseiveState; //接收状态
 if (objShortMessageEN.ReturnTime !=  "")
 {
objRow[conShortMessage.ReturnTime] = objShortMessageEN.ReturnTime; //状态返回时间
 }
 if (objShortMessageEN.Memo !=  "")
 {
objRow[conShortMessage.Memo] = objShortMessageEN.Memo; //备注
 }
objDS.Tables[clsShortMessageEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsShortMessageEN._CurrTabName);
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
 /// <param name = "objShortMessageEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsShortMessageEN objShortMessageEN)
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objShortMessageEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objShortMessageEN.MessageNumber !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.MessageNumber);
 var strMessageNumber = objShortMessageEN.MessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageNumber + "'");
 }
 
 if (objShortMessageEN.SendMessageNumber !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.SendMessageNumber);
 var strSendMessageNumber = objShortMessageEN.SendMessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSendMessageNumber + "'");
 }
 
 if (objShortMessageEN.Phone !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.Phone);
 var strPhone = objShortMessageEN.Phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhone + "'");
 }
 
 if (objShortMessageEN.MessageContent !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.MessageContent);
 var strMessageContent = objShortMessageEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageContent + "'");
 }
 
 if (objShortMessageEN.ShortMessageSendSateID  ==  "")
 {
 objShortMessageEN.ShortMessageSendSateID = null;
 }
 if (objShortMessageEN.ShortMessageSendSateID !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.ShortMessageSendSateID);
 var strShortMessageSendSateID = objShortMessageEN.ShortMessageSendSateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShortMessageSendSateID + "'");
 }
 
 arrFieldListForInsert.Add(conShortMessage.ReseiveState);
 arrValueListForInsert.Add("'" + (objShortMessageEN.ReseiveState  ==  false ? "0" : "1") + "'");
 
 if (objShortMessageEN.ReturnTime !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.ReturnTime);
 var strReturnTime = objShortMessageEN.ReturnTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTime + "'");
 }
 
 if (objShortMessageEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.Memo);
 var strMemo = objShortMessageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ShortMessage");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objShortMessageEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsShortMessageEN objShortMessageEN)
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objShortMessageEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objShortMessageEN.MessageNumber !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.MessageNumber);
 var strMessageNumber = objShortMessageEN.MessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageNumber + "'");
 }
 
 if (objShortMessageEN.SendMessageNumber !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.SendMessageNumber);
 var strSendMessageNumber = objShortMessageEN.SendMessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSendMessageNumber + "'");
 }
 
 if (objShortMessageEN.Phone !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.Phone);
 var strPhone = objShortMessageEN.Phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhone + "'");
 }
 
 if (objShortMessageEN.MessageContent !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.MessageContent);
 var strMessageContent = objShortMessageEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageContent + "'");
 }
 
 if (objShortMessageEN.ShortMessageSendSateID  ==  "")
 {
 objShortMessageEN.ShortMessageSendSateID = null;
 }
 if (objShortMessageEN.ShortMessageSendSateID !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.ShortMessageSendSateID);
 var strShortMessageSendSateID = objShortMessageEN.ShortMessageSendSateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShortMessageSendSateID + "'");
 }
 
 arrFieldListForInsert.Add(conShortMessage.ReseiveState);
 arrValueListForInsert.Add("'" + (objShortMessageEN.ReseiveState  ==  false ? "0" : "1") + "'");
 
 if (objShortMessageEN.ReturnTime !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.ReturnTime);
 var strReturnTime = objShortMessageEN.ReturnTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTime + "'");
 }
 
 if (objShortMessageEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.Memo);
 var strMemo = objShortMessageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ShortMessage");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objShortMessageEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsShortMessageEN objShortMessageEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objShortMessageEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objShortMessageEN.MessageNumber !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.MessageNumber);
 var strMessageNumber = objShortMessageEN.MessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageNumber + "'");
 }
 
 if (objShortMessageEN.SendMessageNumber !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.SendMessageNumber);
 var strSendMessageNumber = objShortMessageEN.SendMessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSendMessageNumber + "'");
 }
 
 if (objShortMessageEN.Phone !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.Phone);
 var strPhone = objShortMessageEN.Phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhone + "'");
 }
 
 if (objShortMessageEN.MessageContent !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.MessageContent);
 var strMessageContent = objShortMessageEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageContent + "'");
 }
 
 if (objShortMessageEN.ShortMessageSendSateID  ==  "")
 {
 objShortMessageEN.ShortMessageSendSateID = null;
 }
 if (objShortMessageEN.ShortMessageSendSateID !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.ShortMessageSendSateID);
 var strShortMessageSendSateID = objShortMessageEN.ShortMessageSendSateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShortMessageSendSateID + "'");
 }
 
 arrFieldListForInsert.Add(conShortMessage.ReseiveState);
 arrValueListForInsert.Add("'" + (objShortMessageEN.ReseiveState  ==  false ? "0" : "1") + "'");
 
 if (objShortMessageEN.ReturnTime !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.ReturnTime);
 var strReturnTime = objShortMessageEN.ReturnTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTime + "'");
 }
 
 if (objShortMessageEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.Memo);
 var strMemo = objShortMessageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ShortMessage");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objShortMessageEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsShortMessageEN objShortMessageEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objShortMessageEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objShortMessageEN.MessageNumber !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.MessageNumber);
 var strMessageNumber = objShortMessageEN.MessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageNumber + "'");
 }
 
 if (objShortMessageEN.SendMessageNumber !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.SendMessageNumber);
 var strSendMessageNumber = objShortMessageEN.SendMessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSendMessageNumber + "'");
 }
 
 if (objShortMessageEN.Phone !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.Phone);
 var strPhone = objShortMessageEN.Phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhone + "'");
 }
 
 if (objShortMessageEN.MessageContent !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.MessageContent);
 var strMessageContent = objShortMessageEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageContent + "'");
 }
 
 if (objShortMessageEN.ShortMessageSendSateID  ==  "")
 {
 objShortMessageEN.ShortMessageSendSateID = null;
 }
 if (objShortMessageEN.ShortMessageSendSateID !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.ShortMessageSendSateID);
 var strShortMessageSendSateID = objShortMessageEN.ShortMessageSendSateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShortMessageSendSateID + "'");
 }
 
 arrFieldListForInsert.Add(conShortMessage.ReseiveState);
 arrValueListForInsert.Add("'" + (objShortMessageEN.ReseiveState  ==  false ? "0" : "1") + "'");
 
 if (objShortMessageEN.ReturnTime !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.ReturnTime);
 var strReturnTime = objShortMessageEN.ReturnTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTime + "'");
 }
 
 if (objShortMessageEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conShortMessage.Memo);
 var strMemo = objShortMessageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ShortMessage");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewShortMessages(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where ShortMessageId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ShortMessage");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngShortMessageId = TransNullToInt(oRow[conShortMessage.ShortMessageId].ToString().Trim());
if (IsExist(lngShortMessageId))
{
 string strResult = "关键字变量值为:" + string.Format("ShortMessageId = {0}", lngShortMessageId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsShortMessageEN._CurrTabName ].NewRow();
objRow[conShortMessage.MessageNumber] = oRow[conShortMessage.MessageNumber].ToString().Trim(); //消息编号
objRow[conShortMessage.SendMessageNumber] = oRow[conShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objRow[conShortMessage.Phone] = oRow[conShortMessage.Phone].ToString().Trim(); //手机号
objRow[conShortMessage.MessageContent] = oRow[conShortMessage.MessageContent].ToString().Trim(); //消息内容
objRow[conShortMessage.ShortMessageSendSateID] = oRow[conShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objRow[conShortMessage.ReseiveState] = oRow[conShortMessage.ReseiveState].ToString().Trim(); //接收状态
objRow[conShortMessage.ReturnTime] = oRow[conShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objRow[conShortMessage.Memo] = oRow[conShortMessage.Memo].ToString().Trim(); //备注
 objDS.Tables[clsShortMessageEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsShortMessageEN._CurrTabName);
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
 /// <param name = "objShortMessageEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsShortMessageEN objShortMessageEN)
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objShortMessageEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from ShortMessage where ShortMessageId = " + ""+ objShortMessageEN.ShortMessageId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsShortMessageEN._CurrTabName);
if (objDS.Tables[clsShortMessageEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ShortMessageId = " + ""+ objShortMessageEN.ShortMessageId+"");
return false;
}
objRow = objDS.Tables[clsShortMessageEN._CurrTabName].Rows[0];
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageNumber))
 {
objRow[conShortMessage.MessageNumber] = objShortMessageEN.MessageNumber; //消息编号
 }
 if (objShortMessageEN.IsUpdated(conShortMessage.SendMessageNumber))
 {
objRow[conShortMessage.SendMessageNumber] = objShortMessageEN.SendMessageNumber; //发送消息编号
 }
 if (objShortMessageEN.IsUpdated(conShortMessage.Phone))
 {
objRow[conShortMessage.Phone] = objShortMessageEN.Phone; //手机号
 }
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageContent))
 {
objRow[conShortMessage.MessageContent] = objShortMessageEN.MessageContent; //消息内容
 }
 if (objShortMessageEN.IsUpdated(conShortMessage.ShortMessageSendSateID))
 {
objRow[conShortMessage.ShortMessageSendSateID] = objShortMessageEN.ShortMessageSendSateID; //消息发送状态Id
 }
 if (objShortMessageEN.IsUpdated(conShortMessage.ReseiveState))
 {
objRow[conShortMessage.ReseiveState] = objShortMessageEN.ReseiveState; //接收状态
 }
 if (objShortMessageEN.IsUpdated(conShortMessage.ReturnTime))
 {
objRow[conShortMessage.ReturnTime] = objShortMessageEN.ReturnTime; //状态返回时间
 }
 if (objShortMessageEN.IsUpdated(conShortMessage.Memo))
 {
objRow[conShortMessage.Memo] = objShortMessageEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsShortMessageEN._CurrTabName);
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
 /// <param name = "objShortMessageEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsShortMessageEN objShortMessageEN)
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objShortMessageEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ShortMessage Set ");
 
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageNumber))
 {
 if (objShortMessageEN.MessageNumber !=  null)
 {
 var strMessageNumber = objShortMessageEN.MessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageNumber, conShortMessage.MessageNumber); //消息编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.MessageNumber); //消息编号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.SendMessageNumber))
 {
 if (objShortMessageEN.SendMessageNumber !=  null)
 {
 var strSendMessageNumber = objShortMessageEN.SendMessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSendMessageNumber, conShortMessage.SendMessageNumber); //发送消息编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.SendMessageNumber); //发送消息编号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.Phone))
 {
 if (objShortMessageEN.Phone !=  null)
 {
 var strPhone = objShortMessageEN.Phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhone, conShortMessage.Phone); //手机号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.Phone); //手机号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageContent))
 {
 if (objShortMessageEN.MessageContent !=  null)
 {
 var strMessageContent = objShortMessageEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageContent, conShortMessage.MessageContent); //消息内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.MessageContent); //消息内容
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ShortMessageSendSateID))
 {
 if (objShortMessageEN.ShortMessageSendSateID  ==  "")
 {
 objShortMessageEN.ShortMessageSendSateID = null;
 }
 if (objShortMessageEN.ShortMessageSendSateID !=  null)
 {
 var strShortMessageSendSateID = objShortMessageEN.ShortMessageSendSateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShortMessageSendSateID, conShortMessage.ShortMessageSendSateID); //消息发送状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.ShortMessageSendSateID); //消息发送状态Id
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ReseiveState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objShortMessageEN.ReseiveState == true?"1":"0", conShortMessage.ReseiveState); //接收状态
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ReturnTime))
 {
 if (objShortMessageEN.ReturnTime !=  null)
 {
 var strReturnTime = objShortMessageEN.ReturnTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTime, conShortMessage.ReturnTime); //状态返回时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.ReturnTime); //状态返回时间
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.Memo))
 {
 if (objShortMessageEN.Memo !=  null)
 {
 var strMemo = objShortMessageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conShortMessage.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ShortMessageId = {0}", objShortMessageEN.ShortMessageId); 
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
 /// <param name = "objShortMessageEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsShortMessageEN objShortMessageEN, string strCondition)
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objShortMessageEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ShortMessage Set ");
 
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageNumber))
 {
 if (objShortMessageEN.MessageNumber !=  null)
 {
 var strMessageNumber = objShortMessageEN.MessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageNumber = '{0}',", strMessageNumber); //消息编号
 }
 else
 {
 sbSQL.Append(" MessageNumber = null,"); //消息编号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.SendMessageNumber))
 {
 if (objShortMessageEN.SendMessageNumber !=  null)
 {
 var strSendMessageNumber = objShortMessageEN.SendMessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SendMessageNumber = '{0}',", strSendMessageNumber); //发送消息编号
 }
 else
 {
 sbSQL.Append(" SendMessageNumber = null,"); //发送消息编号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.Phone))
 {
 if (objShortMessageEN.Phone !=  null)
 {
 var strPhone = objShortMessageEN.Phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Phone = '{0}',", strPhone); //手机号
 }
 else
 {
 sbSQL.Append(" Phone = null,"); //手机号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageContent))
 {
 if (objShortMessageEN.MessageContent !=  null)
 {
 var strMessageContent = objShortMessageEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageContent = '{0}',", strMessageContent); //消息内容
 }
 else
 {
 sbSQL.Append(" MessageContent = null,"); //消息内容
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ShortMessageSendSateID))
 {
 if (objShortMessageEN.ShortMessageSendSateID  ==  "")
 {
 objShortMessageEN.ShortMessageSendSateID = null;
 }
 if (objShortMessageEN.ShortMessageSendSateID !=  null)
 {
 var strShortMessageSendSateID = objShortMessageEN.ShortMessageSendSateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShortMessageSendSateID = '{0}',", strShortMessageSendSateID); //消息发送状态Id
 }
 else
 {
 sbSQL.Append(" ShortMessageSendSateID = null,"); //消息发送状态Id
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ReseiveState))
 {
 sbSQL.AppendFormat(" ReseiveState = '{0}',", objShortMessageEN.ReseiveState == true?"1":"0"); //接收状态
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ReturnTime))
 {
 if (objShortMessageEN.ReturnTime !=  null)
 {
 var strReturnTime = objShortMessageEN.ReturnTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTime = '{0}',", strReturnTime); //状态返回时间
 }
 else
 {
 sbSQL.Append(" ReturnTime = null,"); //状态返回时间
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.Memo))
 {
 if (objShortMessageEN.Memo !=  null)
 {
 var strMemo = objShortMessageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objShortMessageEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsShortMessageEN objShortMessageEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objShortMessageEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ShortMessage Set ");
 
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageNumber))
 {
 if (objShortMessageEN.MessageNumber !=  null)
 {
 var strMessageNumber = objShortMessageEN.MessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageNumber = '{0}',", strMessageNumber); //消息编号
 }
 else
 {
 sbSQL.Append(" MessageNumber = null,"); //消息编号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.SendMessageNumber))
 {
 if (objShortMessageEN.SendMessageNumber !=  null)
 {
 var strSendMessageNumber = objShortMessageEN.SendMessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SendMessageNumber = '{0}',", strSendMessageNumber); //发送消息编号
 }
 else
 {
 sbSQL.Append(" SendMessageNumber = null,"); //发送消息编号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.Phone))
 {
 if (objShortMessageEN.Phone !=  null)
 {
 var strPhone = objShortMessageEN.Phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Phone = '{0}',", strPhone); //手机号
 }
 else
 {
 sbSQL.Append(" Phone = null,"); //手机号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageContent))
 {
 if (objShortMessageEN.MessageContent !=  null)
 {
 var strMessageContent = objShortMessageEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageContent = '{0}',", strMessageContent); //消息内容
 }
 else
 {
 sbSQL.Append(" MessageContent = null,"); //消息内容
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ShortMessageSendSateID))
 {
 if (objShortMessageEN.ShortMessageSendSateID  ==  "")
 {
 objShortMessageEN.ShortMessageSendSateID = null;
 }
 if (objShortMessageEN.ShortMessageSendSateID !=  null)
 {
 var strShortMessageSendSateID = objShortMessageEN.ShortMessageSendSateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShortMessageSendSateID = '{0}',", strShortMessageSendSateID); //消息发送状态Id
 }
 else
 {
 sbSQL.Append(" ShortMessageSendSateID = null,"); //消息发送状态Id
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ReseiveState))
 {
 sbSQL.AppendFormat(" ReseiveState = '{0}',", objShortMessageEN.ReseiveState == true?"1":"0"); //接收状态
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ReturnTime))
 {
 if (objShortMessageEN.ReturnTime !=  null)
 {
 var strReturnTime = objShortMessageEN.ReturnTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTime = '{0}',", strReturnTime); //状态返回时间
 }
 else
 {
 sbSQL.Append(" ReturnTime = null,"); //状态返回时间
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.Memo))
 {
 if (objShortMessageEN.Memo !=  null)
 {
 var strMemo = objShortMessageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objShortMessageEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsShortMessageEN objShortMessageEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objShortMessageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objShortMessageEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ShortMessage Set ");
 
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageNumber))
 {
 if (objShortMessageEN.MessageNumber !=  null)
 {
 var strMessageNumber = objShortMessageEN.MessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageNumber, conShortMessage.MessageNumber); //消息编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.MessageNumber); //消息编号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.SendMessageNumber))
 {
 if (objShortMessageEN.SendMessageNumber !=  null)
 {
 var strSendMessageNumber = objShortMessageEN.SendMessageNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSendMessageNumber, conShortMessage.SendMessageNumber); //发送消息编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.SendMessageNumber); //发送消息编号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.Phone))
 {
 if (objShortMessageEN.Phone !=  null)
 {
 var strPhone = objShortMessageEN.Phone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhone, conShortMessage.Phone); //手机号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.Phone); //手机号
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.MessageContent))
 {
 if (objShortMessageEN.MessageContent !=  null)
 {
 var strMessageContent = objShortMessageEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageContent, conShortMessage.MessageContent); //消息内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.MessageContent); //消息内容
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ShortMessageSendSateID))
 {
 if (objShortMessageEN.ShortMessageSendSateID  ==  "")
 {
 objShortMessageEN.ShortMessageSendSateID = null;
 }
 if (objShortMessageEN.ShortMessageSendSateID !=  null)
 {
 var strShortMessageSendSateID = objShortMessageEN.ShortMessageSendSateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShortMessageSendSateID, conShortMessage.ShortMessageSendSateID); //消息发送状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.ShortMessageSendSateID); //消息发送状态Id
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ReseiveState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objShortMessageEN.ReseiveState == true?"1":"0", conShortMessage.ReseiveState); //接收状态
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.ReturnTime))
 {
 if (objShortMessageEN.ReturnTime !=  null)
 {
 var strReturnTime = objShortMessageEN.ReturnTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTime, conShortMessage.ReturnTime); //状态返回时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.ReturnTime); //状态返回时间
 }
 }
 
 if (objShortMessageEN.IsUpdated(conShortMessage.Memo))
 {
 if (objShortMessageEN.Memo !=  null)
 {
 var strMemo = objShortMessageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conShortMessage.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conShortMessage.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ShortMessageId = {0}", objShortMessageEN.ShortMessageId); 
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
 /// <param name = "lngShortMessageId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngShortMessageId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngShortMessageId,
};
 objSQL.ExecSP("ShortMessage_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngShortMessageId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngShortMessageId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
//删除ShortMessage本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ShortMessage where ShortMessageId = " + ""+ lngShortMessageId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelShortMessage(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
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
//删除ShortMessage本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ShortMessage where ShortMessageId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngShortMessageId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngShortMessageId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
//删除ShortMessage本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ShortMessage where ShortMessageId = " + ""+ lngShortMessageId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelShortMessage(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsShortMessageDA: DelShortMessage)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ShortMessage where " + strCondition ;
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
public bool DelShortMessageWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsShortMessageDA: DelShortMessageWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsShortMessageDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ShortMessage where " + strCondition ;
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
 /// <param name = "objShortMessageENS">源对象</param>
 /// <param name = "objShortMessageENT">目标对象</param>
public void CopyTo(clsShortMessageEN objShortMessageENS, clsShortMessageEN objShortMessageENT)
{
objShortMessageENT.ShortMessageId = objShortMessageENS.ShortMessageId; //短信消息Id
objShortMessageENT.MessageNumber = objShortMessageENS.MessageNumber; //消息编号
objShortMessageENT.SendMessageNumber = objShortMessageENS.SendMessageNumber; //发送消息编号
objShortMessageENT.Phone = objShortMessageENS.Phone; //手机号
objShortMessageENT.MessageContent = objShortMessageENS.MessageContent; //消息内容
objShortMessageENT.ShortMessageSendSateID = objShortMessageENS.ShortMessageSendSateID; //消息发送状态Id
objShortMessageENT.ReseiveState = objShortMessageENS.ReseiveState; //接收状态
objShortMessageENT.ReturnTime = objShortMessageENS.ReturnTime; //状态返回时间
objShortMessageENT.Memo = objShortMessageENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsShortMessageEN objShortMessageEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objShortMessageEN.ShortMessageSendSateID, conShortMessage.ShortMessageSendSateID);
//检查字段长度
clsCheckSql.CheckFieldLen(objShortMessageEN.MessageNumber, 200, conShortMessage.MessageNumber);
clsCheckSql.CheckFieldLen(objShortMessageEN.SendMessageNumber, 200, conShortMessage.SendMessageNumber);
clsCheckSql.CheckFieldLen(objShortMessageEN.Phone, 200, conShortMessage.Phone);
clsCheckSql.CheckFieldLen(objShortMessageEN.MessageContent, 2000, conShortMessage.MessageContent);
clsCheckSql.CheckFieldLen(objShortMessageEN.ShortMessageSendSateID, 8, conShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckFieldLen(objShortMessageEN.ReturnTime, 20, conShortMessage.ReturnTime);
clsCheckSql.CheckFieldLen(objShortMessageEN.Memo, 1000, conShortMessage.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objShortMessageEN.ShortMessageSendSateID, 8, conShortMessage.ShortMessageSendSateID);
 objShortMessageEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsShortMessageEN objShortMessageEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objShortMessageEN.MessageNumber, 200, conShortMessage.MessageNumber);
clsCheckSql.CheckFieldLen(objShortMessageEN.SendMessageNumber, 200, conShortMessage.SendMessageNumber);
clsCheckSql.CheckFieldLen(objShortMessageEN.Phone, 200, conShortMessage.Phone);
clsCheckSql.CheckFieldLen(objShortMessageEN.MessageContent, 2000, conShortMessage.MessageContent);
clsCheckSql.CheckFieldLen(objShortMessageEN.ShortMessageSendSateID, 8, conShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckFieldLen(objShortMessageEN.ReturnTime, 20, conShortMessage.ReturnTime);
clsCheckSql.CheckFieldLen(objShortMessageEN.Memo, 1000, conShortMessage.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objShortMessageEN.ShortMessageSendSateID, 8, conShortMessage.ShortMessageSendSateID);
 objShortMessageEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsShortMessageEN objShortMessageEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objShortMessageEN.MessageNumber, 200, conShortMessage.MessageNumber);
clsCheckSql.CheckFieldLen(objShortMessageEN.SendMessageNumber, 200, conShortMessage.SendMessageNumber);
clsCheckSql.CheckFieldLen(objShortMessageEN.Phone, 200, conShortMessage.Phone);
clsCheckSql.CheckFieldLen(objShortMessageEN.MessageContent, 2000, conShortMessage.MessageContent);
clsCheckSql.CheckFieldLen(objShortMessageEN.ShortMessageSendSateID, 8, conShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckFieldLen(objShortMessageEN.ReturnTime, 20, conShortMessage.ReturnTime);
clsCheckSql.CheckFieldLen(objShortMessageEN.Memo, 1000, conShortMessage.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objShortMessageEN.MessageNumber, conShortMessage.MessageNumber);
clsCheckSql.CheckSqlInjection4Field(objShortMessageEN.SendMessageNumber, conShortMessage.SendMessageNumber);
clsCheckSql.CheckSqlInjection4Field(objShortMessageEN.Phone, conShortMessage.Phone);
clsCheckSql.CheckSqlInjection4Field(objShortMessageEN.MessageContent, conShortMessage.MessageContent);
clsCheckSql.CheckSqlInjection4Field(objShortMessageEN.ShortMessageSendSateID, conShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckSqlInjection4Field(objShortMessageEN.ReturnTime, conShortMessage.ReturnTime);
clsCheckSql.CheckSqlInjection4Field(objShortMessageEN.Memo, conShortMessage.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objShortMessageEN.ShortMessageSendSateID, 8, conShortMessage.ShortMessageSendSateID);
 objShortMessageEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ShortMessage(短信消息),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objShortMessageEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsShortMessageEN objShortMessageEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ShortMessageSendSateID = '{0}'", objShortMessageEN.ShortMessageSendSateID);
 if (objShortMessageEN.Phone == null)
{
 sbCondition.AppendFormat(" and Phone is null");
}
else
{
 sbCondition.AppendFormat(" and Phone = '{0}'", objShortMessageEN.Phone);
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
 objSQL = clsShortMessageDA.GetSpecSQLObj();
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
 objSQL = clsShortMessageDA.GetSpecSQLObj();
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
 objSQL = clsShortMessageDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsShortMessageEN._CurrTabName);
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
 objSQL = clsShortMessageDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsShortMessageEN._CurrTabName, strCondition);
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
 objSQL = clsShortMessageDA.GetSpecSQLObj();
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
 objSQL = clsShortMessageDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}