
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMessagePushDA
 表名:MessagePush(01120280)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
 /// 消息推送(MessagePush)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsMessagePushDA : clsCommBase4DA
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
 return clsMessagePushEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsMessagePushEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMessagePushEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsMessagePushEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsMessagePushEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strMessagePushId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strMessagePushId)
{
strMessagePushId = strMessagePushId.Replace("'", "''");
if (strMessagePushId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:MessagePush中,检查关键字,长度不正确!(clsMessagePushDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMessagePushId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:MessagePush中,关键字不能为空 或 null!(clsMessagePushDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMessagePushId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsMessagePushDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_MessagePush(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTable_MessagePush)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MessagePush where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MessagePush where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from MessagePush where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MessagePush.* from MessagePush Left Join {1} on {2} where {3} and MessagePush.MessagePushId not in (Select top {5} MessagePush.MessagePushId from MessagePush Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MessagePush where {1} and MessagePushId not in (Select top {2} MessagePushId from MessagePush where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MessagePush where {1} and MessagePushId not in (Select top {3} MessagePushId from MessagePush where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsMessagePushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} MessagePush.* from MessagePush Left Join {1} on {2} where {3} and MessagePush.MessagePushId not in (Select top {5} MessagePush.MessagePushId from MessagePush Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from MessagePush where {1} and MessagePushId not in (Select top {2} MessagePushId from MessagePush where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from MessagePush where {1} and MessagePushId not in (Select top {3} MessagePushId from MessagePush where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsMessagePushEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsMessagePushDA:GetObjLst)", objException.Message));
}
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = TransNullToBool(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = TransNullToBool(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMessagePushDA: GetObjLst)", objException.Message));
}
objMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMessagePushEN);
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
public List<clsMessagePushEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsMessagePushDA:GetObjLstByTabName)", objException.Message));
}
List<clsMessagePushEN> arrObjLst = new List<clsMessagePushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = TransNullToBool(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = TransNullToBool(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsMessagePushDA: GetObjLst)", objException.Message));
}
objMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objMessagePushEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objMessagePushEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetMessagePush(ref clsMessagePushEN objMessagePushEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where MessagePushId = " + "'"+ objMessagePushEN.MessagePushId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objMessagePushEN.MessagePushId = objDT.Rows[0][conMessagePush.MessagePushId].ToString().Trim(); //消息Id(字段类型:char,字段长度:8,是否可空:False)
 objMessagePushEN.MessagePushNumber = objDT.Rows[0][conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objMessagePushEN.MessageTitle = objDT.Rows[0][conMessagePush.MessageTitle].ToString().Trim(); //消息标题(字段类型:varchar,字段长度:500,是否可空:True)
 objMessagePushEN.MessageContent = objDT.Rows[0][conMessagePush.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objMessagePushEN.ReceivePeople = objDT.Rows[0][conMessagePush.ReceivePeople].ToString().Trim(); //接收人员(字段类型:varchar,字段长度:50,是否可空:True)
 objMessagePushEN.MessageTypeId = objDT.Rows[0][conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id(字段类型:char,字段长度:8,是否可空:False)
 objMessagePushEN.IsAllpush = TransNullToBool(objDT.Rows[0][conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送(字段类型:bit,字段长度:1,是否可空:True)
 objMessagePushEN.IsReceive = TransNullToBool(objDT.Rows[0][conMessagePush.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objMessagePushEN.ClientVersionTypeId = objDT.Rows[0][conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id(字段类型:char,字段长度:8,是否可空:False)
 objMessagePushEN.UpdDate = objDT.Rows[0][conMessagePush.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objMessagePushEN.Memo = objDT.Rows[0][conMessagePush.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsMessagePushDA: GetMessagePush)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMessagePushId">表关键字</param>
 /// <returns>表对象</returns>
public clsMessagePushEN GetObjByMessagePushId(string strMessagePushId)
{
CheckPrimaryKey(strMessagePushId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where MessagePushId = " + "'"+ strMessagePushId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
 objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id(字段类型:char,字段长度:8,是否可空:False)
 objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题(字段类型:varchar,字段长度:500,是否可空:True)
 objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员(字段类型:varchar,字段长度:50,是否可空:True)
 objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id(字段类型:char,字段长度:8,是否可空:False)
 objMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送(字段类型:bit,字段长度:1,是否可空:True)
 objMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id(字段类型:char,字段长度:8,是否可空:False)
 objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsMessagePushDA: GetObjByMessagePushId)", objException.Message));
}
return objMessagePushEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsMessagePushEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsMessagePushDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN()
{
MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(), //消息Id
MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(), //消息编号
MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(), //消息标题
MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(), //消息内容
ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(), //接收人员
MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(), //消息类型Id
IsAllpush = TransNullToBool(objRow[conMessagePush.IsAllpush].ToString().Trim()), //是否全体推送
IsReceive = TransNullToBool(objRow[conMessagePush.IsReceive].ToString().Trim()), //是否接收
ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(), //客户端版本类型Id
UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim() //备注
};
objMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMessagePushEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsMessagePushDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsMessagePushEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = TransNullToBool(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = TransNullToBool(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsMessagePushDA: GetObjByDataRowMessagePush)", objException.Message));
}
objMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMessagePushEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsMessagePushEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsMessagePushEN objMessagePushEN = new clsMessagePushEN();
try
{
objMessagePushEN.MessagePushId = objRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objMessagePushEN.MessagePushNumber = objRow[conMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objMessagePushEN.MessageTitle = objRow[conMessagePush.MessageTitle] == DBNull.Value ? null : objRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objMessagePushEN.MessageContent = objRow[conMessagePush.MessageContent] == DBNull.Value ? null : objRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objMessagePushEN.ReceivePeople = objRow[conMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objMessagePushEN.MessageTypeId = objRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objMessagePushEN.IsAllpush = TransNullToBool(objRow[conMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objMessagePushEN.IsReceive = TransNullToBool(objRow[conMessagePush.IsReceive].ToString().Trim()); //是否接收
objMessagePushEN.ClientVersionTypeId = objRow[conMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objMessagePushEN.UpdDate = objRow[conMessagePush.UpdDate] == DBNull.Value ? null : objRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objMessagePushEN.Memo = objRow[conMessagePush.Memo] == DBNull.Value ? null : objRow[conMessagePush.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsMessagePushDA: GetObjByDataRow)", objException.Message));
}
objMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objMessagePushEN;
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
objSQL = clsMessagePushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMessagePushEN._CurrTabName, conMessagePush.MessagePushId, 8, "");
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
objSQL = clsMessagePushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsMessagePushEN._CurrTabName, conMessagePush.MessagePushId, 8, strPrefix);
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
 objSQL = clsMessagePushDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MessagePushId from MessagePush where " + strCondition;
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
 objSQL = clsMessagePushDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MessagePushId from MessagePush where " + strCondition;
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
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strMessagePushId)
{
CheckPrimaryKey(strMessagePushId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MessagePush", "MessagePushId = " + "'"+ strMessagePushId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsMessagePushDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("MessagePush", strCondition))
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
objSQL = clsMessagePushDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("MessagePush");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsMessagePushEN objMessagePushEN)
 {
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMessagePushEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MessagePush");
objRow = objDS.Tables["MessagePush"].NewRow();
objRow[conMessagePush.MessagePushId] = objMessagePushEN.MessagePushId; //消息Id
 if (objMessagePushEN.MessagePushNumber !=  "")
 {
objRow[conMessagePush.MessagePushNumber] = objMessagePushEN.MessagePushNumber; //消息编号
 }
 if (objMessagePushEN.MessageTitle !=  "")
 {
objRow[conMessagePush.MessageTitle] = objMessagePushEN.MessageTitle; //消息标题
 }
 if (objMessagePushEN.MessageContent !=  "")
 {
objRow[conMessagePush.MessageContent] = objMessagePushEN.MessageContent; //消息内容
 }
 if (objMessagePushEN.ReceivePeople !=  "")
 {
objRow[conMessagePush.ReceivePeople] = objMessagePushEN.ReceivePeople; //接收人员
 }
objRow[conMessagePush.MessageTypeId] = objMessagePushEN.MessageTypeId; //消息类型Id
objRow[conMessagePush.IsAllpush] = objMessagePushEN.IsAllpush; //是否全体推送
objRow[conMessagePush.IsReceive] = objMessagePushEN.IsReceive; //是否接收
 if (objMessagePushEN.ClientVersionTypeId !=  "")
 {
objRow[conMessagePush.ClientVersionTypeId] = objMessagePushEN.ClientVersionTypeId; //客户端版本类型Id
 }
 if (objMessagePushEN.UpdDate !=  "")
 {
objRow[conMessagePush.UpdDate] = objMessagePushEN.UpdDate; //修改日期
 }
 if (objMessagePushEN.Memo !=  "")
 {
objRow[conMessagePush.Memo] = objMessagePushEN.Memo; //备注
 }
objDS.Tables[clsMessagePushEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsMessagePushEN._CurrTabName);
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMessagePushEN objMessagePushEN)
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMessagePushEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMessagePushEN.MessagePushId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessagePushId);
 var strMessagePushId = objMessagePushEN.MessagePushId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessagePushId + "'");
 }
 
 if (objMessagePushEN.MessagePushNumber !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessagePushNumber);
 var strMessagePushNumber = objMessagePushEN.MessagePushNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessagePushNumber + "'");
 }
 
 if (objMessagePushEN.MessageTitle !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageTitle);
 var strMessageTitle = objMessagePushEN.MessageTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageTitle + "'");
 }
 
 if (objMessagePushEN.MessageContent !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageContent);
 var strMessageContent = objMessagePushEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageContent + "'");
 }
 
 if (objMessagePushEN.ReceivePeople !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.ReceivePeople);
 var strReceivePeople = objMessagePushEN.ReceivePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceivePeople + "'");
 }
 
 if (objMessagePushEN.MessageTypeId  ==  "")
 {
 objMessagePushEN.MessageTypeId = null;
 }
 if (objMessagePushEN.MessageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageTypeId);
 var strMessageTypeId = objMessagePushEN.MessageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conMessagePush.IsAllpush);
 arrValueListForInsert.Add("'" + (objMessagePushEN.IsAllpush  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conMessagePush.IsReceive);
 arrValueListForInsert.Add("'" + (objMessagePushEN.IsReceive  ==  false ? "0" : "1") + "'");
 
 if (objMessagePushEN.ClientVersionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.ClientVersionTypeId);
 var strClientVersionTypeId = objMessagePushEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionTypeId + "'");
 }
 
 if (objMessagePushEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.UpdDate);
 var strUpdDate = objMessagePushEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMessagePushEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.Memo);
 var strMemo = objMessagePushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MessagePush");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMessagePushEN objMessagePushEN)
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMessagePushEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMessagePushEN.MessagePushId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessagePushId);
 var strMessagePushId = objMessagePushEN.MessagePushId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessagePushId + "'");
 }
 
 if (objMessagePushEN.MessagePushNumber !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessagePushNumber);
 var strMessagePushNumber = objMessagePushEN.MessagePushNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessagePushNumber + "'");
 }
 
 if (objMessagePushEN.MessageTitle !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageTitle);
 var strMessageTitle = objMessagePushEN.MessageTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageTitle + "'");
 }
 
 if (objMessagePushEN.MessageContent !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageContent);
 var strMessageContent = objMessagePushEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageContent + "'");
 }
 
 if (objMessagePushEN.ReceivePeople !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.ReceivePeople);
 var strReceivePeople = objMessagePushEN.ReceivePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceivePeople + "'");
 }
 
 if (objMessagePushEN.MessageTypeId  ==  "")
 {
 objMessagePushEN.MessageTypeId = null;
 }
 if (objMessagePushEN.MessageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageTypeId);
 var strMessageTypeId = objMessagePushEN.MessageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conMessagePush.IsAllpush);
 arrValueListForInsert.Add("'" + (objMessagePushEN.IsAllpush  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conMessagePush.IsReceive);
 arrValueListForInsert.Add("'" + (objMessagePushEN.IsReceive  ==  false ? "0" : "1") + "'");
 
 if (objMessagePushEN.ClientVersionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.ClientVersionTypeId);
 var strClientVersionTypeId = objMessagePushEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionTypeId + "'");
 }
 
 if (objMessagePushEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.UpdDate);
 var strUpdDate = objMessagePushEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMessagePushEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.Memo);
 var strMemo = objMessagePushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MessagePush");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objMessagePushEN.MessagePushId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsMessagePushEN objMessagePushEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMessagePushEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMessagePushEN.MessagePushId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessagePushId);
 var strMessagePushId = objMessagePushEN.MessagePushId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessagePushId + "'");
 }
 
 if (objMessagePushEN.MessagePushNumber !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessagePushNumber);
 var strMessagePushNumber = objMessagePushEN.MessagePushNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessagePushNumber + "'");
 }
 
 if (objMessagePushEN.MessageTitle !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageTitle);
 var strMessageTitle = objMessagePushEN.MessageTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageTitle + "'");
 }
 
 if (objMessagePushEN.MessageContent !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageContent);
 var strMessageContent = objMessagePushEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageContent + "'");
 }
 
 if (objMessagePushEN.ReceivePeople !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.ReceivePeople);
 var strReceivePeople = objMessagePushEN.ReceivePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceivePeople + "'");
 }
 
 if (objMessagePushEN.MessageTypeId  ==  "")
 {
 objMessagePushEN.MessageTypeId = null;
 }
 if (objMessagePushEN.MessageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageTypeId);
 var strMessageTypeId = objMessagePushEN.MessageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conMessagePush.IsAllpush);
 arrValueListForInsert.Add("'" + (objMessagePushEN.IsAllpush  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conMessagePush.IsReceive);
 arrValueListForInsert.Add("'" + (objMessagePushEN.IsReceive  ==  false ? "0" : "1") + "'");
 
 if (objMessagePushEN.ClientVersionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.ClientVersionTypeId);
 var strClientVersionTypeId = objMessagePushEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionTypeId + "'");
 }
 
 if (objMessagePushEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.UpdDate);
 var strUpdDate = objMessagePushEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMessagePushEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.Memo);
 var strMemo = objMessagePushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MessagePush");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objMessagePushEN.MessagePushId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsMessagePushEN objMessagePushEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objMessagePushEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objMessagePushEN.MessagePushId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessagePushId);
 var strMessagePushId = objMessagePushEN.MessagePushId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessagePushId + "'");
 }
 
 if (objMessagePushEN.MessagePushNumber !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessagePushNumber);
 var strMessagePushNumber = objMessagePushEN.MessagePushNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessagePushNumber + "'");
 }
 
 if (objMessagePushEN.MessageTitle !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageTitle);
 var strMessageTitle = objMessagePushEN.MessageTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageTitle + "'");
 }
 
 if (objMessagePushEN.MessageContent !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageContent);
 var strMessageContent = objMessagePushEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageContent + "'");
 }
 
 if (objMessagePushEN.ReceivePeople !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.ReceivePeople);
 var strReceivePeople = objMessagePushEN.ReceivePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReceivePeople + "'");
 }
 
 if (objMessagePushEN.MessageTypeId  ==  "")
 {
 objMessagePushEN.MessageTypeId = null;
 }
 if (objMessagePushEN.MessageTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.MessageTypeId);
 var strMessageTypeId = objMessagePushEN.MessageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMessageTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conMessagePush.IsAllpush);
 arrValueListForInsert.Add("'" + (objMessagePushEN.IsAllpush  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conMessagePush.IsReceive);
 arrValueListForInsert.Add("'" + (objMessagePushEN.IsReceive  ==  false ? "0" : "1") + "'");
 
 if (objMessagePushEN.ClientVersionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.ClientVersionTypeId);
 var strClientVersionTypeId = objMessagePushEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClientVersionTypeId + "'");
 }
 
 if (objMessagePushEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.UpdDate);
 var strUpdDate = objMessagePushEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objMessagePushEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conMessagePush.Memo);
 var strMemo = objMessagePushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into MessagePush");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewMessagePushs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where MessagePushId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "MessagePush");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strMessagePushId = oRow[conMessagePush.MessagePushId].ToString().Trim();
if (IsExist(strMessagePushId))
{
 string strResult = "关键字变量值为:" + string.Format("MessagePushId = {0}", strMessagePushId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsMessagePushEN._CurrTabName ].NewRow();
objRow[conMessagePush.MessagePushId] = oRow[conMessagePush.MessagePushId].ToString().Trim(); //消息Id
objRow[conMessagePush.MessagePushNumber] = oRow[conMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objRow[conMessagePush.MessageTitle] = oRow[conMessagePush.MessageTitle].ToString().Trim(); //消息标题
objRow[conMessagePush.MessageContent] = oRow[conMessagePush.MessageContent].ToString().Trim(); //消息内容
objRow[conMessagePush.ReceivePeople] = oRow[conMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objRow[conMessagePush.MessageTypeId] = oRow[conMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objRow[conMessagePush.IsAllpush] = oRow[conMessagePush.IsAllpush].ToString().Trim(); //是否全体推送
objRow[conMessagePush.IsReceive] = oRow[conMessagePush.IsReceive].ToString().Trim(); //是否接收
objRow[conMessagePush.ClientVersionTypeId] = oRow[conMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objRow[conMessagePush.UpdDate] = oRow[conMessagePush.UpdDate].ToString().Trim(); //修改日期
objRow[conMessagePush.Memo] = oRow[conMessagePush.Memo].ToString().Trim(); //备注
 objDS.Tables[clsMessagePushEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsMessagePushEN._CurrTabName);
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
 /// <param name = "objMessagePushEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsMessagePushEN objMessagePushEN)
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMessagePushEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from MessagePush where MessagePushId = " + "'"+ objMessagePushEN.MessagePushId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsMessagePushEN._CurrTabName);
if (objDS.Tables[clsMessagePushEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:MessagePushId = " + "'"+ objMessagePushEN.MessagePushId+"'");
return false;
}
objRow = objDS.Tables[clsMessagePushEN._CurrTabName].Rows[0];
 if (objMessagePushEN.IsUpdated(conMessagePush.MessagePushId))
 {
objRow[conMessagePush.MessagePushId] = objMessagePushEN.MessagePushId; //消息Id
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.MessagePushNumber))
 {
objRow[conMessagePush.MessagePushNumber] = objMessagePushEN.MessagePushNumber; //消息编号
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTitle))
 {
objRow[conMessagePush.MessageTitle] = objMessagePushEN.MessageTitle; //消息标题
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageContent))
 {
objRow[conMessagePush.MessageContent] = objMessagePushEN.MessageContent; //消息内容
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.ReceivePeople))
 {
objRow[conMessagePush.ReceivePeople] = objMessagePushEN.ReceivePeople; //接收人员
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTypeId))
 {
objRow[conMessagePush.MessageTypeId] = objMessagePushEN.MessageTypeId; //消息类型Id
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.IsAllpush))
 {
objRow[conMessagePush.IsAllpush] = objMessagePushEN.IsAllpush; //是否全体推送
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.IsReceive))
 {
objRow[conMessagePush.IsReceive] = objMessagePushEN.IsReceive; //是否接收
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.ClientVersionTypeId))
 {
objRow[conMessagePush.ClientVersionTypeId] = objMessagePushEN.ClientVersionTypeId; //客户端版本类型Id
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.UpdDate))
 {
objRow[conMessagePush.UpdDate] = objMessagePushEN.UpdDate; //修改日期
 }
 if (objMessagePushEN.IsUpdated(conMessagePush.Memo))
 {
objRow[conMessagePush.Memo] = objMessagePushEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsMessagePushEN._CurrTabName);
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMessagePushEN objMessagePushEN)
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMessagePushEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update MessagePush Set ");
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessagePushNumber))
 {
 if (objMessagePushEN.MessagePushNumber !=  null)
 {
 var strMessagePushNumber = objMessagePushEN.MessagePushNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessagePushNumber, conMessagePush.MessagePushNumber); //消息编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.MessagePushNumber); //消息编号
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTitle))
 {
 if (objMessagePushEN.MessageTitle !=  null)
 {
 var strMessageTitle = objMessagePushEN.MessageTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageTitle, conMessagePush.MessageTitle); //消息标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.MessageTitle); //消息标题
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageContent))
 {
 if (objMessagePushEN.MessageContent !=  null)
 {
 var strMessageContent = objMessagePushEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageContent, conMessagePush.MessageContent); //消息内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.MessageContent); //消息内容
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.ReceivePeople))
 {
 if (objMessagePushEN.ReceivePeople !=  null)
 {
 var strReceivePeople = objMessagePushEN.ReceivePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReceivePeople, conMessagePush.ReceivePeople); //接收人员
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.ReceivePeople); //接收人员
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTypeId))
 {
 if (objMessagePushEN.MessageTypeId  ==  "")
 {
 objMessagePushEN.MessageTypeId = null;
 }
 if (objMessagePushEN.MessageTypeId !=  null)
 {
 var strMessageTypeId = objMessagePushEN.MessageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageTypeId, conMessagePush.MessageTypeId); //消息类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.MessageTypeId); //消息类型Id
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.IsAllpush))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMessagePushEN.IsAllpush == true?"1":"0", conMessagePush.IsAllpush); //是否全体推送
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.IsReceive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMessagePushEN.IsReceive == true?"1":"0", conMessagePush.IsReceive); //是否接收
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.ClientVersionTypeId))
 {
 if (objMessagePushEN.ClientVersionTypeId !=  null)
 {
 var strClientVersionTypeId = objMessagePushEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClientVersionTypeId, conMessagePush.ClientVersionTypeId); //客户端版本类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.ClientVersionTypeId); //客户端版本类型Id
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.UpdDate))
 {
 if (objMessagePushEN.UpdDate !=  null)
 {
 var strUpdDate = objMessagePushEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conMessagePush.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.UpdDate); //修改日期
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.Memo))
 {
 if (objMessagePushEN.Memo !=  null)
 {
 var strMemo = objMessagePushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMessagePush.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MessagePushId = '{0}'", objMessagePushEN.MessagePushId); 
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
 /// <param name = "objMessagePushEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsMessagePushEN objMessagePushEN, string strCondition)
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMessagePushEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MessagePush Set ");
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessagePushNumber))
 {
 if (objMessagePushEN.MessagePushNumber !=  null)
 {
 var strMessagePushNumber = objMessagePushEN.MessagePushNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessagePushNumber = '{0}',", strMessagePushNumber); //消息编号
 }
 else
 {
 sbSQL.Append(" MessagePushNumber = null,"); //消息编号
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTitle))
 {
 if (objMessagePushEN.MessageTitle !=  null)
 {
 var strMessageTitle = objMessagePushEN.MessageTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageTitle = '{0}',", strMessageTitle); //消息标题
 }
 else
 {
 sbSQL.Append(" MessageTitle = null,"); //消息标题
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageContent))
 {
 if (objMessagePushEN.MessageContent !=  null)
 {
 var strMessageContent = objMessagePushEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageContent = '{0}',", strMessageContent); //消息内容
 }
 else
 {
 sbSQL.Append(" MessageContent = null,"); //消息内容
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.ReceivePeople))
 {
 if (objMessagePushEN.ReceivePeople !=  null)
 {
 var strReceivePeople = objMessagePushEN.ReceivePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReceivePeople = '{0}',", strReceivePeople); //接收人员
 }
 else
 {
 sbSQL.Append(" ReceivePeople = null,"); //接收人员
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTypeId))
 {
 if (objMessagePushEN.MessageTypeId  ==  "")
 {
 objMessagePushEN.MessageTypeId = null;
 }
 if (objMessagePushEN.MessageTypeId !=  null)
 {
 var strMessageTypeId = objMessagePushEN.MessageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageTypeId = '{0}',", strMessageTypeId); //消息类型Id
 }
 else
 {
 sbSQL.Append(" MessageTypeId = null,"); //消息类型Id
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.IsAllpush))
 {
 sbSQL.AppendFormat(" IsAllpush = '{0}',", objMessagePushEN.IsAllpush == true?"1":"0"); //是否全体推送
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.IsReceive))
 {
 sbSQL.AppendFormat(" IsReceive = '{0}',", objMessagePushEN.IsReceive == true?"1":"0"); //是否接收
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.ClientVersionTypeId))
 {
 if (objMessagePushEN.ClientVersionTypeId !=  null)
 {
 var strClientVersionTypeId = objMessagePushEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClientVersionTypeId = '{0}',", strClientVersionTypeId); //客户端版本类型Id
 }
 else
 {
 sbSQL.Append(" ClientVersionTypeId = null,"); //客户端版本类型Id
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.UpdDate))
 {
 if (objMessagePushEN.UpdDate !=  null)
 {
 var strUpdDate = objMessagePushEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.Memo))
 {
 if (objMessagePushEN.Memo !=  null)
 {
 var strMemo = objMessagePushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMessagePushEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsMessagePushEN objMessagePushEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMessagePushEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MessagePush Set ");
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessagePushNumber))
 {
 if (objMessagePushEN.MessagePushNumber !=  null)
 {
 var strMessagePushNumber = objMessagePushEN.MessagePushNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessagePushNumber = '{0}',", strMessagePushNumber); //消息编号
 }
 else
 {
 sbSQL.Append(" MessagePushNumber = null,"); //消息编号
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTitle))
 {
 if (objMessagePushEN.MessageTitle !=  null)
 {
 var strMessageTitle = objMessagePushEN.MessageTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageTitle = '{0}',", strMessageTitle); //消息标题
 }
 else
 {
 sbSQL.Append(" MessageTitle = null,"); //消息标题
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageContent))
 {
 if (objMessagePushEN.MessageContent !=  null)
 {
 var strMessageContent = objMessagePushEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageContent = '{0}',", strMessageContent); //消息内容
 }
 else
 {
 sbSQL.Append(" MessageContent = null,"); //消息内容
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.ReceivePeople))
 {
 if (objMessagePushEN.ReceivePeople !=  null)
 {
 var strReceivePeople = objMessagePushEN.ReceivePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReceivePeople = '{0}',", strReceivePeople); //接收人员
 }
 else
 {
 sbSQL.Append(" ReceivePeople = null,"); //接收人员
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTypeId))
 {
 if (objMessagePushEN.MessageTypeId  ==  "")
 {
 objMessagePushEN.MessageTypeId = null;
 }
 if (objMessagePushEN.MessageTypeId !=  null)
 {
 var strMessageTypeId = objMessagePushEN.MessageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MessageTypeId = '{0}',", strMessageTypeId); //消息类型Id
 }
 else
 {
 sbSQL.Append(" MessageTypeId = null,"); //消息类型Id
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.IsAllpush))
 {
 sbSQL.AppendFormat(" IsAllpush = '{0}',", objMessagePushEN.IsAllpush == true?"1":"0"); //是否全体推送
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.IsReceive))
 {
 sbSQL.AppendFormat(" IsReceive = '{0}',", objMessagePushEN.IsReceive == true?"1":"0"); //是否接收
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.ClientVersionTypeId))
 {
 if (objMessagePushEN.ClientVersionTypeId !=  null)
 {
 var strClientVersionTypeId = objMessagePushEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClientVersionTypeId = '{0}',", strClientVersionTypeId); //客户端版本类型Id
 }
 else
 {
 sbSQL.Append(" ClientVersionTypeId = null,"); //客户端版本类型Id
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.UpdDate))
 {
 if (objMessagePushEN.UpdDate !=  null)
 {
 var strUpdDate = objMessagePushEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.Memo))
 {
 if (objMessagePushEN.Memo !=  null)
 {
 var strMemo = objMessagePushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objMessagePushEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsMessagePushEN objMessagePushEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objMessagePushEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objMessagePushEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objMessagePushEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update MessagePush Set ");
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessagePushNumber))
 {
 if (objMessagePushEN.MessagePushNumber !=  null)
 {
 var strMessagePushNumber = objMessagePushEN.MessagePushNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessagePushNumber, conMessagePush.MessagePushNumber); //消息编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.MessagePushNumber); //消息编号
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTitle))
 {
 if (objMessagePushEN.MessageTitle !=  null)
 {
 var strMessageTitle = objMessagePushEN.MessageTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageTitle, conMessagePush.MessageTitle); //消息标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.MessageTitle); //消息标题
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageContent))
 {
 if (objMessagePushEN.MessageContent !=  null)
 {
 var strMessageContent = objMessagePushEN.MessageContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageContent, conMessagePush.MessageContent); //消息内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.MessageContent); //消息内容
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.ReceivePeople))
 {
 if (objMessagePushEN.ReceivePeople !=  null)
 {
 var strReceivePeople = objMessagePushEN.ReceivePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReceivePeople, conMessagePush.ReceivePeople); //接收人员
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.ReceivePeople); //接收人员
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.MessageTypeId))
 {
 if (objMessagePushEN.MessageTypeId  ==  "")
 {
 objMessagePushEN.MessageTypeId = null;
 }
 if (objMessagePushEN.MessageTypeId !=  null)
 {
 var strMessageTypeId = objMessagePushEN.MessageTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMessageTypeId, conMessagePush.MessageTypeId); //消息类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.MessageTypeId); //消息类型Id
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.IsAllpush))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMessagePushEN.IsAllpush == true?"1":"0", conMessagePush.IsAllpush); //是否全体推送
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.IsReceive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objMessagePushEN.IsReceive == true?"1":"0", conMessagePush.IsReceive); //是否接收
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.ClientVersionTypeId))
 {
 if (objMessagePushEN.ClientVersionTypeId !=  null)
 {
 var strClientVersionTypeId = objMessagePushEN.ClientVersionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClientVersionTypeId, conMessagePush.ClientVersionTypeId); //客户端版本类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.ClientVersionTypeId); //客户端版本类型Id
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.UpdDate))
 {
 if (objMessagePushEN.UpdDate !=  null)
 {
 var strUpdDate = objMessagePushEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conMessagePush.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.UpdDate); //修改日期
 }
 }
 
 if (objMessagePushEN.IsUpdated(conMessagePush.Memo))
 {
 if (objMessagePushEN.Memo !=  null)
 {
 var strMemo = objMessagePushEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conMessagePush.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conMessagePush.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where MessagePushId = '{0}'", objMessagePushEN.MessagePushId); 
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
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strMessagePushId) 
{
CheckPrimaryKey(strMessagePushId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strMessagePushId,
};
 objSQL.ExecSP("MessagePush_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strMessagePushId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strMessagePushId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
//删除MessagePush本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MessagePush where MessagePushId = " + "'"+ strMessagePushId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelMessagePush(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
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
//删除MessagePush本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MessagePush where MessagePushId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strMessagePushId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strMessagePushId) 
{
CheckPrimaryKey(strMessagePushId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
//删除MessagePush本表中与当前对象有关的记录
strSQL = strSQL + "Delete from MessagePush where MessagePushId = " + "'"+ strMessagePushId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelMessagePush(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsMessagePushDA: DelMessagePush)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MessagePush where " + strCondition ;
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
public bool DelMessagePushWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsMessagePushDA: DelMessagePushWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsMessagePushDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from MessagePush where " + strCondition ;
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
 /// <param name = "objMessagePushENS">源对象</param>
 /// <param name = "objMessagePushENT">目标对象</param>
public void CopyTo(clsMessagePushEN objMessagePushENS, clsMessagePushEN objMessagePushENT)
{
objMessagePushENT.MessagePushId = objMessagePushENS.MessagePushId; //消息Id
objMessagePushENT.MessagePushNumber = objMessagePushENS.MessagePushNumber; //消息编号
objMessagePushENT.MessageTitle = objMessagePushENS.MessageTitle; //消息标题
objMessagePushENT.MessageContent = objMessagePushENS.MessageContent; //消息内容
objMessagePushENT.ReceivePeople = objMessagePushENS.ReceivePeople; //接收人员
objMessagePushENT.MessageTypeId = objMessagePushENS.MessageTypeId; //消息类型Id
objMessagePushENT.IsAllpush = objMessagePushENS.IsAllpush; //是否全体推送
objMessagePushENT.IsReceive = objMessagePushENS.IsReceive; //是否接收
objMessagePushENT.ClientVersionTypeId = objMessagePushENS.ClientVersionTypeId; //客户端版本类型Id
objMessagePushENT.UpdDate = objMessagePushENS.UpdDate; //修改日期
objMessagePushENT.Memo = objMessagePushENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsMessagePushEN objMessagePushEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objMessagePushEN.MessageTypeId, conMessagePush.MessageTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objMessagePushEN.MessagePushId, 8, conMessagePush.MessagePushId);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessagePushNumber, 200, conMessagePush.MessagePushNumber);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageTitle, 500, conMessagePush.MessageTitle);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageContent, 2000, conMessagePush.MessageContent);
clsCheckSql.CheckFieldLen(objMessagePushEN.ReceivePeople, 50, conMessagePush.ReceivePeople);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageTypeId, 8, conMessagePush.MessageTypeId);
clsCheckSql.CheckFieldLen(objMessagePushEN.ClientVersionTypeId, 8, conMessagePush.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(objMessagePushEN.UpdDate, 20, conMessagePush.UpdDate);
clsCheckSql.CheckFieldLen(objMessagePushEN.Memo, 1000, conMessagePush.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objMessagePushEN.MessageTypeId, 8, conMessagePush.MessageTypeId);
 objMessagePushEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsMessagePushEN objMessagePushEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMessagePushEN.MessagePushNumber, 200, conMessagePush.MessagePushNumber);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageTitle, 500, conMessagePush.MessageTitle);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageContent, 2000, conMessagePush.MessageContent);
clsCheckSql.CheckFieldLen(objMessagePushEN.ReceivePeople, 50, conMessagePush.ReceivePeople);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageTypeId, 8, conMessagePush.MessageTypeId);
clsCheckSql.CheckFieldLen(objMessagePushEN.ClientVersionTypeId, 8, conMessagePush.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(objMessagePushEN.UpdDate, 20, conMessagePush.UpdDate);
clsCheckSql.CheckFieldLen(objMessagePushEN.Memo, 1000, conMessagePush.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMessagePushEN.MessageTypeId, 8, conMessagePush.MessageTypeId);
 objMessagePushEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsMessagePushEN objMessagePushEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objMessagePushEN.MessagePushId, 8, conMessagePush.MessagePushId);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessagePushNumber, 200, conMessagePush.MessagePushNumber);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageTitle, 500, conMessagePush.MessageTitle);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageContent, 2000, conMessagePush.MessageContent);
clsCheckSql.CheckFieldLen(objMessagePushEN.ReceivePeople, 50, conMessagePush.ReceivePeople);
clsCheckSql.CheckFieldLen(objMessagePushEN.MessageTypeId, 8, conMessagePush.MessageTypeId);
clsCheckSql.CheckFieldLen(objMessagePushEN.ClientVersionTypeId, 8, conMessagePush.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(objMessagePushEN.UpdDate, 20, conMessagePush.UpdDate);
clsCheckSql.CheckFieldLen(objMessagePushEN.Memo, 1000, conMessagePush.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.MessagePushId, conMessagePush.MessagePushId);
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.MessagePushNumber, conMessagePush.MessagePushNumber);
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.MessageTitle, conMessagePush.MessageTitle);
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.MessageContent, conMessagePush.MessageContent);
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.ReceivePeople, conMessagePush.ReceivePeople);
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.MessageTypeId, conMessagePush.MessageTypeId);
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.ClientVersionTypeId, conMessagePush.ClientVersionTypeId);
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.UpdDate, conMessagePush.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objMessagePushEN.Memo, conMessagePush.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objMessagePushEN.MessageTypeId, 8, conMessagePush.MessageTypeId);
 objMessagePushEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--MessagePush(消息推送),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMessagePushEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsMessagePushEN objMessagePushEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objMessagePushEN.MessagePushNumber == null)
{
 sbCondition.AppendFormat(" and MessagePushNumber is null");
}
else
{
 sbCondition.AppendFormat(" and MessagePushNumber = '{0}'", objMessagePushEN.MessagePushNumber);
}
 if (objMessagePushEN.UpdDate == null)
{
 sbCondition.AppendFormat(" and UpdDate is null");
}
else
{
 sbCondition.AppendFormat(" and UpdDate = '{0}'", objMessagePushEN.UpdDate);
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
 objSQL = clsMessagePushDA.GetSpecSQLObj();
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
 objSQL = clsMessagePushDA.GetSpecSQLObj();
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
 objSQL = clsMessagePushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMessagePushEN._CurrTabName);
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
 objSQL = clsMessagePushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsMessagePushEN._CurrTabName, strCondition);
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
 objSQL = clsMessagePushDA.GetSpecSQLObj();
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
 objSQL = clsMessagePushDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}