
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvShortMessageDA
 表名:vShortMessage(01120288)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:36
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
 /// 短信消息视图(vShortMessage)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvShortMessageDA : clsCommBase4DA
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
 return clsvShortMessageEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvShortMessageEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvShortMessageEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvShortMessageEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvShortMessageEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from vShortMessage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vShortMessage(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTable_vShortMessage)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from vShortMessage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from vShortMessage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vShortMessage where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vShortMessage where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vShortMessage where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vShortMessage.* from vShortMessage Left Join {1} on {2} where {3} and vShortMessage.ShortMessageId not in (Select top {5} vShortMessage.ShortMessageId from vShortMessage Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vShortMessage where {1} and ShortMessageId not in (Select top {2} ShortMessageId from vShortMessage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vShortMessage where {1} and ShortMessageId not in (Select top {3} ShortMessageId from vShortMessage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvShortMessageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vShortMessage.* from vShortMessage Left Join {1} on {2} where {3} and vShortMessage.ShortMessageId not in (Select top {5} vShortMessage.ShortMessageId from vShortMessage Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vShortMessage where {1} and ShortMessageId not in (Select top {2} ShortMessageId from vShortMessage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vShortMessage where {1} and ShortMessageId not in (Select top {3} ShortMessageId from vShortMessage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvShortMessageEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvShortMessageDA:GetObjLst)", objException.Message));
}
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from vShortMessage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = TransNullToInt(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = TransNullToBool(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvShortMessageDA: GetObjLst)", objException.Message));
}
objvShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvShortMessageEN);
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
public List<clsvShortMessageEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvShortMessageDA:GetObjLstByTabName)", objException.Message));
}
List<clsvShortMessageEN> arrObjLst = new List<clsvShortMessageEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = TransNullToInt(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = TransNullToBool(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvShortMessageDA: GetObjLst)", objException.Message));
}
objvShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvShortMessageEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvShortMessageEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvShortMessage(ref clsvShortMessageEN objvShortMessageEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from vShortMessage where ShortMessageId = " + ""+ objvShortMessageEN.ShortMessageId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvShortMessageEN.ShortMessageId = TransNullToInt(objDT.Rows[0][convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvShortMessageEN.MessageNumber = objDT.Rows[0][convShortMessage.MessageNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objvShortMessageEN.SendMessageNumber = objDT.Rows[0][convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objvShortMessageEN.ShortMessageSendSateName = objDT.Rows[0][convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvShortMessageEN.Phone = objDT.Rows[0][convShortMessage.Phone].ToString().Trim(); //手机号(字段类型:varchar,字段长度:200,是否可空:True)
 objvShortMessageEN.MessageContent = objDT.Rows[0][convShortMessage.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvShortMessageEN.ShortMessageSendSateID = objDT.Rows[0][convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id(字段类型:char,字段长度:8,是否可空:False)
 objvShortMessageEN.ReseiveState = TransNullToBool(objDT.Rows[0][convShortMessage.ReseiveState].ToString().Trim()); //接收状态(字段类型:bit,字段长度:1,是否可空:True)
 objvShortMessageEN.ReturnTime = objDT.Rows[0][convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvShortMessageEN.Memo = objDT.Rows[0][convShortMessage.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvShortMessageDA: GetvShortMessage)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngShortMessageId">表关键字</param>
 /// <returns>表对象</returns>
public clsvShortMessageEN GetObjByShortMessageId(long lngShortMessageId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from vShortMessage where ShortMessageId = " + ""+ lngShortMessageId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
 objvShortMessageEN.ShortMessageId = Int32.Parse(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号(字段类型:varchar,字段长度:200,是否可空:True)
 objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号(字段类型:varchar,字段长度:200,是否可空:True)
 objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id(字段类型:char,字段长度:8,是否可空:False)
 objvShortMessageEN.ReseiveState = clsEntityBase2.TransNullToBool_S(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态(字段类型:bit,字段长度:1,是否可空:True)
 objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvShortMessageDA: GetObjByShortMessageId)", objException.Message));
}
return objvShortMessageEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvShortMessageEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvShortMessageDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
strSQL = "Select * from vShortMessage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN()
{
ShortMessageId = TransNullToInt(objRow[convShortMessage.ShortMessageId].ToString().Trim()), //短信消息Id
MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(), //消息编号
SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(), //发送消息编号
ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(), //短消息发送状态名称
Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(), //手机号
MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(), //消息内容
ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(), //消息发送状态Id
ReseiveState = TransNullToBool(objRow[convShortMessage.ReseiveState].ToString().Trim()), //接收状态
ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(), //状态返回时间
Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim() //备注
};
objvShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvShortMessageEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvShortMessageDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvShortMessageEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = TransNullToInt(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = TransNullToBool(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvShortMessageDA: GetObjByDataRowvShortMessage)", objException.Message));
}
objvShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvShortMessageEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvShortMessageEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvShortMessageEN objvShortMessageEN = new clsvShortMessageEN();
try
{
objvShortMessageEN.ShortMessageId = TransNullToInt(objRow[convShortMessage.ShortMessageId].ToString().Trim()); //短信消息Id
objvShortMessageEN.MessageNumber = objRow[convShortMessage.MessageNumber] == DBNull.Value ? null : objRow[convShortMessage.MessageNumber].ToString().Trim(); //消息编号
objvShortMessageEN.SendMessageNumber = objRow[convShortMessage.SendMessageNumber] == DBNull.Value ? null : objRow[convShortMessage.SendMessageNumber].ToString().Trim(); //发送消息编号
objvShortMessageEN.ShortMessageSendSateName = objRow[convShortMessage.ShortMessageSendSateName] == DBNull.Value ? null : objRow[convShortMessage.ShortMessageSendSateName].ToString().Trim(); //短消息发送状态名称
objvShortMessageEN.Phone = objRow[convShortMessage.Phone] == DBNull.Value ? null : objRow[convShortMessage.Phone].ToString().Trim(); //手机号
objvShortMessageEN.MessageContent = objRow[convShortMessage.MessageContent] == DBNull.Value ? null : objRow[convShortMessage.MessageContent].ToString().Trim(); //消息内容
objvShortMessageEN.ShortMessageSendSateID = objRow[convShortMessage.ShortMessageSendSateID].ToString().Trim(); //消息发送状态Id
objvShortMessageEN.ReseiveState = TransNullToBool(objRow[convShortMessage.ReseiveState].ToString().Trim()); //接收状态
objvShortMessageEN.ReturnTime = objRow[convShortMessage.ReturnTime] == DBNull.Value ? null : objRow[convShortMessage.ReturnTime].ToString().Trim(); //状态返回时间
objvShortMessageEN.Memo = objRow[convShortMessage.Memo] == DBNull.Value ? null : objRow[convShortMessage.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvShortMessageDA: GetObjByDataRow)", objException.Message));
}
objvShortMessageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvShortMessageEN;
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
objSQL = clsvShortMessageDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvShortMessageEN._CurrTabName, convShortMessage.ShortMessageId, 8, "");
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
objSQL = clsvShortMessageDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvShortMessageEN._CurrTabName, convShortMessage.ShortMessageId, 8, strPrefix);
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
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ShortMessageId from vShortMessage where " + strCondition;
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
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ShortMessageId from vShortMessage where " + strCondition;
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
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vShortMessage", "ShortMessageId = " + ""+ lngShortMessageId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvShortMessageDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vShortMessage", strCondition))
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
objSQL = clsvShortMessageDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vShortMessage");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvShortMessageENS">源对象</param>
 /// <param name = "objvShortMessageENT">目标对象</param>
public void CopyTo(clsvShortMessageEN objvShortMessageENS, clsvShortMessageEN objvShortMessageENT)
{
objvShortMessageENT.ShortMessageId = objvShortMessageENS.ShortMessageId; //短信消息Id
objvShortMessageENT.MessageNumber = objvShortMessageENS.MessageNumber; //消息编号
objvShortMessageENT.SendMessageNumber = objvShortMessageENS.SendMessageNumber; //发送消息编号
objvShortMessageENT.ShortMessageSendSateName = objvShortMessageENS.ShortMessageSendSateName; //短消息发送状态名称
objvShortMessageENT.Phone = objvShortMessageENS.Phone; //手机号
objvShortMessageENT.MessageContent = objvShortMessageENS.MessageContent; //消息内容
objvShortMessageENT.ShortMessageSendSateID = objvShortMessageENS.ShortMessageSendSateID; //消息发送状态Id
objvShortMessageENT.ReseiveState = objvShortMessageENS.ReseiveState; //接收状态
objvShortMessageENT.ReturnTime = objvShortMessageENS.ReturnTime; //状态返回时间
objvShortMessageENT.Memo = objvShortMessageENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvShortMessageEN objvShortMessageEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvShortMessageEN.MessageNumber, 200, convShortMessage.MessageNumber);
clsCheckSql.CheckFieldLen(objvShortMessageEN.SendMessageNumber, 200, convShortMessage.SendMessageNumber);
clsCheckSql.CheckFieldLen(objvShortMessageEN.ShortMessageSendSateName, 200, convShortMessage.ShortMessageSendSateName);
clsCheckSql.CheckFieldLen(objvShortMessageEN.Phone, 200, convShortMessage.Phone);
clsCheckSql.CheckFieldLen(objvShortMessageEN.MessageContent, 2000, convShortMessage.MessageContent);
clsCheckSql.CheckFieldLen(objvShortMessageEN.ShortMessageSendSateID, 8, convShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckFieldLen(objvShortMessageEN.ReturnTime, 20, convShortMessage.ReturnTime);
clsCheckSql.CheckFieldLen(objvShortMessageEN.Memo, 1000, convShortMessage.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvShortMessageEN.MessageNumber, convShortMessage.MessageNumber);
clsCheckSql.CheckSqlInjection4Field(objvShortMessageEN.SendMessageNumber, convShortMessage.SendMessageNumber);
clsCheckSql.CheckSqlInjection4Field(objvShortMessageEN.ShortMessageSendSateName, convShortMessage.ShortMessageSendSateName);
clsCheckSql.CheckSqlInjection4Field(objvShortMessageEN.Phone, convShortMessage.Phone);
clsCheckSql.CheckSqlInjection4Field(objvShortMessageEN.MessageContent, convShortMessage.MessageContent);
clsCheckSql.CheckSqlInjection4Field(objvShortMessageEN.ShortMessageSendSateID, convShortMessage.ShortMessageSendSateID);
clsCheckSql.CheckSqlInjection4Field(objvShortMessageEN.ReturnTime, convShortMessage.ReturnTime);
clsCheckSql.CheckSqlInjection4Field(objvShortMessageEN.Memo, convShortMessage.Memo);
//检查外键字段长度
 objvShortMessageEN._IsCheckProperty = true;
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
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
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
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
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
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvShortMessageEN._CurrTabName);
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
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvShortMessageEN._CurrTabName, strCondition);
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
 objSQL = clsvShortMessageDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}