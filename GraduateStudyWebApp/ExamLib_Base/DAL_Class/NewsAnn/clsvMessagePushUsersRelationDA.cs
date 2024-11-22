
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMessagePushUsersRelationDA
 表名:vMessagePushUsersRelation(01120285)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:37
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
 /// 消息推送用户关系视图(vMessagePushUsersRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMessagePushUsersRelationDA : clsCommBase4DA
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
 return clsvMessagePushUsersRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMessagePushUsersRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMessagePushUsersRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMessagePushUsersRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMessagePushUsersRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePushUsersRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMessagePushUsersRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTable_vMessagePushUsersRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePushUsersRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePushUsersRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMessagePushUsersRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMessagePushUsersRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMessagePushUsersRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMessagePushUsersRelation.* from vMessagePushUsersRelation Left Join {1} on {2} where {3} and vMessagePushUsersRelation.MessagePushUsersRelationId not in (Select top {5} vMessagePushUsersRelation.MessagePushUsersRelationId from vMessagePushUsersRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMessagePushUsersRelation where {1} and MessagePushUsersRelationId not in (Select top {2} MessagePushUsersRelationId from vMessagePushUsersRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMessagePushUsersRelation where {1} and MessagePushUsersRelationId not in (Select top {3} MessagePushUsersRelationId from vMessagePushUsersRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMessagePushUsersRelation.* from vMessagePushUsersRelation Left Join {1} on {2} where {3} and vMessagePushUsersRelation.MessagePushUsersRelationId not in (Select top {5} vMessagePushUsersRelation.MessagePushUsersRelationId from vMessagePushUsersRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMessagePushUsersRelation where {1} and MessagePushUsersRelationId not in (Select top {2} MessagePushUsersRelationId from vMessagePushUsersRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMessagePushUsersRelation where {1} and MessagePushUsersRelationId not in (Select top {3} MessagePushUsersRelationId from vMessagePushUsersRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMessagePushUsersRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA:GetObjLst)", objException.Message));
}
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePushUsersRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = TransNullToInt(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = TransNullToBool(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = TransNullToBool(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMessagePushUsersRelationDA: GetObjLst)", objException.Message));
}
objvMessagePushUsersRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMessagePushUsersRelationEN);
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
public List<clsvMessagePushUsersRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMessagePushUsersRelationEN> arrObjLst = new List<clsvMessagePushUsersRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = TransNullToInt(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = TransNullToBool(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = TransNullToBool(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMessagePushUsersRelationDA: GetObjLst)", objException.Message));
}
objvMessagePushUsersRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMessagePushUsersRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMessagePushUsersRelation(ref clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePushUsersRelation where MessagePushUsersRelationId = " + ""+ objvMessagePushUsersRelationEN.MessagePushUsersRelationId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMessagePushUsersRelationEN.MessagePushUsersRelationId = TransNullToInt(objDT.Rows[0][convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvMessagePushUsersRelationEN.MessagePushId = objDT.Rows[0][convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushUsersRelationEN.MessagePushNumber = objDT.Rows[0][convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objvMessagePushUsersRelationEN.MessageTitle = objDT.Rows[0][convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题(字段类型:varchar,字段长度:500,是否可空:True)
 objvMessagePushUsersRelationEN.MessageContent = objDT.Rows[0][convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMessagePushUsersRelationEN.MessageTypeId = objDT.Rows[0][convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushUsersRelationEN.IsAllpush = TransNullToBool(objDT.Rows[0][convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送(字段类型:bit,字段长度:1,是否可空:True)
 objvMessagePushUsersRelationEN.ClientVersionTypeId = objDT.Rows[0][convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushUsersRelationEN.ReceivePeople = objDT.Rows[0][convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员(字段类型:varchar,字段长度:50,是否可空:True)
 objvMessagePushUsersRelationEN.IsReceive = TransNullToBool(objDT.Rows[0][convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objvMessagePushUsersRelationEN.CreateTime = objDT.Rows[0][convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:16,是否可空:True)
 objvMessagePushUsersRelationEN.Memo = objDT.Rows[0][convMessagePushUsersRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMessagePushUsersRelationDA: GetvMessagePushUsersRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngMessagePushUsersRelationId">表关键字</param>
 /// <returns>表对象</returns>
public clsvMessagePushUsersRelationEN GetObjByMessagePushUsersRelationId(long lngMessagePushUsersRelationId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePushUsersRelation where MessagePushUsersRelationId = " + ""+ lngMessagePushUsersRelationId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
 objvMessagePushUsersRelationEN.MessagePushUsersRelationId = Int32.Parse(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题(字段类型:varchar,字段长度:500,是否可空:True)
 objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushUsersRelationEN.IsAllpush = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送(字段类型:bit,字段长度:1,是否可空:True)
 objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员(字段类型:varchar,字段长度:50,是否可空:True)
 objvMessagePushUsersRelationEN.IsReceive = clsEntityBase2.TransNullToBool_S(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收(字段类型:bit,字段长度:1,是否可空:True)
 objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间(字段类型:varchar,字段长度:16,是否可空:True)
 objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMessagePushUsersRelationDA: GetObjByMessagePushUsersRelationId)", objException.Message));
}
return objvMessagePushUsersRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMessagePushUsersRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
strSQL = "Select * from vMessagePushUsersRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN()
{
MessagePushUsersRelationId = TransNullToInt(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()), //消息推送与用户关系Id
MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(), //消息Id
MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(), //消息编号
MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(), //消息标题
MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(), //消息内容
MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(), //消息类型Id
IsAllpush = TransNullToBool(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()), //是否全体推送
ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(), //客户端版本类型Id
ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(), //接收人员
IsReceive = TransNullToBool(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()), //是否接收
CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(), //建立时间
Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim() //备注
};
objvMessagePushUsersRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMessagePushUsersRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMessagePushUsersRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMessagePushUsersRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = TransNullToInt(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = TransNullToBool(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = TransNullToBool(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMessagePushUsersRelationDA: GetObjByDataRowvMessagePushUsersRelation)", objException.Message));
}
objvMessagePushUsersRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMessagePushUsersRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMessagePushUsersRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN = new clsvMessagePushUsersRelationEN();
try
{
objvMessagePushUsersRelationEN.MessagePushUsersRelationId = TransNullToInt(objRow[convMessagePushUsersRelation.MessagePushUsersRelationId].ToString().Trim()); //消息推送与用户关系Id
objvMessagePushUsersRelationEN.MessagePushId = objRow[convMessagePushUsersRelation.MessagePushId].ToString().Trim(); //消息Id
objvMessagePushUsersRelationEN.MessagePushNumber = objRow[convMessagePushUsersRelation.MessagePushNumber] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessagePushNumber].ToString().Trim(); //消息编号
objvMessagePushUsersRelationEN.MessageTitle = objRow[convMessagePushUsersRelation.MessageTitle] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTitle].ToString().Trim(); //消息标题
objvMessagePushUsersRelationEN.MessageContent = objRow[convMessagePushUsersRelation.MessageContent] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageContent].ToString().Trim(); //消息内容
objvMessagePushUsersRelationEN.MessageTypeId = objRow[convMessagePushUsersRelation.MessageTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.MessageTypeId].ToString().Trim(); //消息类型Id
objvMessagePushUsersRelationEN.IsAllpush = TransNullToBool(objRow[convMessagePushUsersRelation.IsAllpush].ToString().Trim()); //是否全体推送
objvMessagePushUsersRelationEN.ClientVersionTypeId = objRow[convMessagePushUsersRelation.ClientVersionTypeId] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objvMessagePushUsersRelationEN.ReceivePeople = objRow[convMessagePushUsersRelation.ReceivePeople].ToString().Trim(); //接收人员
objvMessagePushUsersRelationEN.IsReceive = TransNullToBool(objRow[convMessagePushUsersRelation.IsReceive].ToString().Trim()); //是否接收
objvMessagePushUsersRelationEN.CreateTime = objRow[convMessagePushUsersRelation.CreateTime] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.CreateTime].ToString().Trim(); //建立时间
objvMessagePushUsersRelationEN.Memo = objRow[convMessagePushUsersRelation.Memo] == DBNull.Value ? null : objRow[convMessagePushUsersRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMessagePushUsersRelationDA: GetObjByDataRow)", objException.Message));
}
objvMessagePushUsersRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMessagePushUsersRelationEN;
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
objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMessagePushUsersRelationEN._CurrTabName, convMessagePushUsersRelation.MessagePushUsersRelationId, 8, "");
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
objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMessagePushUsersRelationEN._CurrTabName, convMessagePushUsersRelation.MessagePushUsersRelationId, 8, strPrefix);
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
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select MessagePushUsersRelationId from vMessagePushUsersRelation where " + strCondition;
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
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select MessagePushUsersRelationId from vMessagePushUsersRelation where " + strCondition;
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
 /// <param name = "lngMessagePushUsersRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngMessagePushUsersRelationId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMessagePushUsersRelation", "MessagePushUsersRelationId = " + ""+ lngMessagePushUsersRelationId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMessagePushUsersRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMessagePushUsersRelation", strCondition))
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
objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMessagePushUsersRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMessagePushUsersRelationENS">源对象</param>
 /// <param name = "objvMessagePushUsersRelationENT">目标对象</param>
public void CopyTo(clsvMessagePushUsersRelationEN objvMessagePushUsersRelationENS, clsvMessagePushUsersRelationEN objvMessagePushUsersRelationENT)
{
objvMessagePushUsersRelationENT.MessagePushUsersRelationId = objvMessagePushUsersRelationENS.MessagePushUsersRelationId; //消息推送与用户关系Id
objvMessagePushUsersRelationENT.MessagePushId = objvMessagePushUsersRelationENS.MessagePushId; //消息Id
objvMessagePushUsersRelationENT.MessagePushNumber = objvMessagePushUsersRelationENS.MessagePushNumber; //消息编号
objvMessagePushUsersRelationENT.MessageTitle = objvMessagePushUsersRelationENS.MessageTitle; //消息标题
objvMessagePushUsersRelationENT.MessageContent = objvMessagePushUsersRelationENS.MessageContent; //消息内容
objvMessagePushUsersRelationENT.MessageTypeId = objvMessagePushUsersRelationENS.MessageTypeId; //消息类型Id
objvMessagePushUsersRelationENT.IsAllpush = objvMessagePushUsersRelationENS.IsAllpush; //是否全体推送
objvMessagePushUsersRelationENT.ClientVersionTypeId = objvMessagePushUsersRelationENS.ClientVersionTypeId; //客户端版本类型Id
objvMessagePushUsersRelationENT.ReceivePeople = objvMessagePushUsersRelationENS.ReceivePeople; //接收人员
objvMessagePushUsersRelationENT.IsReceive = objvMessagePushUsersRelationENS.IsReceive; //是否接收
objvMessagePushUsersRelationENT.CreateTime = objvMessagePushUsersRelationENS.CreateTime; //建立时间
objvMessagePushUsersRelationENT.Memo = objvMessagePushUsersRelationENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMessagePushUsersRelationEN objvMessagePushUsersRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.MessagePushId, 8, convMessagePushUsersRelation.MessagePushId);
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.MessagePushNumber, 200, convMessagePushUsersRelation.MessagePushNumber);
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.MessageTitle, 500, convMessagePushUsersRelation.MessageTitle);
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.MessageContent, 2000, convMessagePushUsersRelation.MessageContent);
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.MessageTypeId, 8, convMessagePushUsersRelation.MessageTypeId);
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.ClientVersionTypeId, 8, convMessagePushUsersRelation.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.ReceivePeople, 50, convMessagePushUsersRelation.ReceivePeople);
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.CreateTime, 16, convMessagePushUsersRelation.CreateTime);
clsCheckSql.CheckFieldLen(objvMessagePushUsersRelationEN.Memo, 1000, convMessagePushUsersRelation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.MessagePushId, convMessagePushUsersRelation.MessagePushId);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.MessagePushNumber, convMessagePushUsersRelation.MessagePushNumber);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.MessageTitle, convMessagePushUsersRelation.MessageTitle);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.MessageContent, convMessagePushUsersRelation.MessageContent);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.MessageTypeId, convMessagePushUsersRelation.MessageTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.ClientVersionTypeId, convMessagePushUsersRelation.ClientVersionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.ReceivePeople, convMessagePushUsersRelation.ReceivePeople);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.CreateTime, convMessagePushUsersRelation.CreateTime);
clsCheckSql.CheckSqlInjection4Field(objvMessagePushUsersRelationEN.Memo, convMessagePushUsersRelation.Memo);
//检查外键字段长度
 objvMessagePushUsersRelationEN._IsCheckProperty = true;
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
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
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
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
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
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMessagePushUsersRelationEN._CurrTabName);
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
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMessagePushUsersRelationEN._CurrTabName, strCondition);
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
 objSQL = clsvMessagePushUsersRelationDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}