
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMessagePushDA
 表名:vMessagePush(01120282)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:29
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
 /// 消息推送视图(vMessagePush)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMessagePushDA : clsCommBase4DA
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
 return clsvMessagePushEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMessagePushEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMessagePushEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMessagePushEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMessagePushEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vMessagePush中,检查关键字,长度不正确!(clsvMessagePushDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strMessagePushId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vMessagePush中,关键字不能为空 或 null!(clsvMessagePushDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMessagePushId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvMessagePushDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMessagePush(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTable_vMessagePush)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePush where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePush where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMessagePush where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMessagePush where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMessagePush where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMessagePush.* from vMessagePush Left Join {1} on {2} where {3} and vMessagePush.MessagePushId not in (Select top {5} vMessagePush.MessagePushId from vMessagePush Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMessagePush where {1} and MessagePushId not in (Select top {2} MessagePushId from vMessagePush where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMessagePush where {1} and MessagePushId not in (Select top {3} MessagePushId from vMessagePush where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMessagePushDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMessagePush.* from vMessagePush Left Join {1} on {2} where {3} and vMessagePush.MessagePushId not in (Select top {5} vMessagePush.MessagePushId from vMessagePush Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMessagePush where {1} and MessagePushId not in (Select top {2} MessagePushId from vMessagePush where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMessagePush where {1} and MessagePushId not in (Select top {3} MessagePushId from vMessagePush where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMessagePushEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMessagePushDA:GetObjLst)", objException.Message));
}
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = TransNullToBool(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = TransNullToBool(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMessagePushDA: GetObjLst)", objException.Message));
}
objvMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMessagePushEN);
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
public List<clsvMessagePushEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMessagePushDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMessagePushEN> arrObjLst = new List<clsvMessagePushEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = TransNullToBool(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = TransNullToBool(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMessagePushDA: GetObjLst)", objException.Message));
}
objvMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMessagePushEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMessagePushEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMessagePush(ref clsvMessagePushEN objvMessagePushEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePush where MessagePushId = " + "'"+ objvMessagePushEN.MessagePushId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMessagePushEN.MessagePushId = objDT.Rows[0][convMessagePush.MessagePushId].ToString().Trim(); //消息Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushEN.MessagePushNumber = objDT.Rows[0][convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objvMessagePushEN.MessageTitle = objDT.Rows[0][convMessagePush.MessageTitle].ToString().Trim(); //消息标题(字段类型:varchar,字段长度:500,是否可空:True)
 objvMessagePushEN.MessageContent = objDT.Rows[0][convMessagePush.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMessagePushEN.ReceivePeople = objDT.Rows[0][convMessagePush.ReceivePeople].ToString().Trim(); //接收人员(字段类型:varchar,字段长度:50,是否可空:True)
 objvMessagePushEN.MessageTypeId = objDT.Rows[0][convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushEN.MessageTypeName = objDT.Rows[0][convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMessagePushEN.IsAllpush = TransNullToBool(objDT.Rows[0][convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送(字段类型:bit,字段长度:1,是否可空:True)
 objvMessagePushEN.IsReceive = TransNullToBool(objDT.Rows[0][convMessagePush.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objvMessagePushEN.ClientVersionTypeId = objDT.Rows[0][convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushEN.UpdDate = objDT.Rows[0][convMessagePush.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMessagePushEN.Memo = objDT.Rows[0][convMessagePush.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMessagePushDA: GetvMessagePush)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMessagePushId">表关键字</param>
 /// <returns>表对象</returns>
public clsvMessagePushEN GetObjByMessagePushId(string strMessagePushId)
{
CheckPrimaryKey(strMessagePushId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePush where MessagePushId = " + "'"+ strMessagePushId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
 objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题(字段类型:varchar,字段长度:500,是否可空:True)
 objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员(字段类型:varchar,字段长度:50,是否可空:True)
 objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMessagePushEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送(字段类型:bit,字段长度:1,是否可空:True)
 objvMessagePushEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMessagePushDA: GetObjByMessagePushId)", objException.Message));
}
return objvMessagePushEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMessagePushEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMessagePushDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePush where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN()
{
MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(), //消息Id
MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(), //消息编号
MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(), //消息标题
MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(), //消息内容
ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(), //接收人员
MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(), //消息类型Id
MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(), //消息类型名称
IsAllpush = TransNullToBool(objRow[convMessagePush.IsAllpush].ToString().Trim()), //是否全体推送
IsReceive = TransNullToBool(objRow[convMessagePush.IsReceive].ToString().Trim()), //是否接收
ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(), //客户端版本类型Id
UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim() //备注
};
objvMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMessagePushEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMessagePushDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMessagePushEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = TransNullToBool(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = TransNullToBool(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMessagePushDA: GetObjByDataRowvMessagePush)", objException.Message));
}
objvMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMessagePushEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMessagePushEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMessagePushEN objvMessagePushEN = new clsvMessagePushEN();
try
{
objvMessagePushEN.MessagePushId = objRow[convMessagePush.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushEN.MessagePushNumber = objRow[convMessagePush.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePush.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushEN.MessageTitle = objRow[convMessagePush.MessageTitle] == DBNull.Value ? null : objRow[convMessagePush.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushEN.MessageContent = objRow[convMessagePush.MessageContent] == DBNull.Value ? null : objRow[convMessagePush.MessageContent].ToString().Trim(); //消息内容
objvMessagePushEN.ReceivePeople = objRow[convMessagePush.ReceivePeople] == DBNull.Value ? null : objRow[convMessagePush.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushEN.MessageTypeId = objRow[convMessagePush.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushEN.MessageTypeName = objRow[convMessagePush.MessageTypeName] == DBNull.Value ? null : objRow[convMessagePush.MessageTypeName].ToString().Trim(); //消息类型名称
objvMessagePushEN.IsAllpush = TransNullToBool(objRow[convMessagePush.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushEN.IsReceive = TransNullToBool(objRow[convMessagePush.IsReceive].ToString().Trim()); //是否接收
objvMessagePushEN.ClientVersionTypeId = objRow[convMessagePush.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePush.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushEN.UpdDate = objRow[convMessagePush.UpdDate] == DBNull.Value ? null : objRow[convMessagePush.UpdDate].ToString().Trim(); //修改日期
objvMessagePushEN.Memo = objRow[convMessagePush.Memo] == DBNull.Value ? null : objRow[convMessagePush.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMessagePushDA: GetObjByDataRow)", objException.Message));
}
objvMessagePushEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMessagePushEN;
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
objSQL = clsvMessagePushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMessagePushEN._CurrTabName, convMessagePush.MessagePushId, 8, "");
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
objSQL = clsvMessagePushDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMessagePushEN._CurrTabName, convMessagePush.MessagePushId, 8, strPrefix);
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
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MessagePushId from vMessagePush where " + strCondition;
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
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MessagePushId from vMessagePush where " + strCondition;
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
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMessagePush", "MessagePushId = " + "'"+ strMessagePushId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMessagePushDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMessagePush", strCondition))
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
objSQL = clsvMessagePushDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMessagePush");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMessagePushENS">源对象</param>
 /// <param name = "objvMessagePushENT">目标对象</param>
public void CopyTo(clsvMessagePushEN objvMessagePushENS, clsvMessagePushEN objvMessagePushENT)
{
objvMessagePushENT.MessagePushId = objvMessagePushENS.MessagePushId; //消息Id
objvMessagePushENT.MessagePushNumber = objvMessagePushENS.MessagePushNumber; //消息编号
objvMessagePushENT.MessageTitle = objvMessagePushENS.MessageTitle; //消息标题
objvMessagePushENT.MessageContent = objvMessagePushENS.MessageContent; //消息内容
objvMessagePushENT.ReceivePeople = objvMessagePushENS.ReceivePeople; //接收人员
objvMessagePushENT.MessageTypeId = objvMessagePushENS.MessageTypeId; //消息类型Id
objvMessagePushENT.MessageTypeName = objvMessagePushENS.MessageTypeName; //消息类型名称
objvMessagePushENT.IsAllpush = objvMessagePushENS.IsAllpush; //是否全体推送
objvMessagePushENT.IsReceive = objvMessagePushENS.IsReceive; //是否接收
objvMessagePushENT.ClientVersionTypeId = objvMessagePushENS.ClientVersionTypeId; //客户端版本类型Id
objvMessagePushENT.UpdDate = objvMessagePushENS.UpdDate; //修改日期
objvMessagePushENT.Memo = objvMessagePushENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMessagePushEN objvMessagePushEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMessagePushEN.MessagePushId, 8, convMessagePush.MessagePushId);
clsCheckSql.CheckFieldLen(objvMessagePushEN.MessagePushNumber, 200, convMessagePush.MessagePushNumber);
clsCheckSql.CheckFieldLen(objvMessagePushEN.MessageTitle, 500, convMessagePush.MessageTitle);
clsCheckSql.CheckFieldLen(objvMessagePushEN.MessageContent, 2000, convMessagePush.MessageContent);
clsCheckSql.CheckFieldLen(objvMessagePushEN.ReceivePeople, 50, convMessagePush.ReceivePeople);
clsCheckSql.CheckFieldLen(objvMessagePushEN.MessageTypeId, 8, convMessagePush.MessageTypeId);
clsCheckSql.CheckFieldLen(objvMessagePushEN.MessageTypeName, 200, convMessagePush.MessageTypeName);
clsCheckSql.CheckFieldLen(objvMessagePushEN.ClientVersionTypeId, 8, convMessagePush.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(objvMessagePushEN.UpdDate, 20, convMessagePush.UpdDate);
clsCheckSql.CheckFieldLen(objvMessagePushEN.Memo, 1000, convMessagePush.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.MessagePushId, convMessagePush.MessagePushId);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.MessagePushNumber, convMessagePush.MessagePushNumber);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.MessageTitle, convMessagePush.MessageTitle);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.MessageContent, convMessagePush.MessageContent);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.ReceivePeople, convMessagePush.ReceivePeople);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.MessageTypeId, convMessagePush.MessageTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.MessageTypeName, convMessagePush.MessageTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.ClientVersionTypeId, convMessagePush.ClientVersionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.UpdDate, convMessagePush.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushEN.Memo, convMessagePush.Memo);
//检查外键字段长度
 objvMessagePushEN._IsCheckProperty = true;
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
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
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
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
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
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMessagePushEN._CurrTabName);
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
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMessagePushEN._CurrTabName, strCondition);
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
 objSQL = clsvMessagePushDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}