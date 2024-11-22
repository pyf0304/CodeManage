
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLiveRoomDA
 表名:LiveRoom(01120263)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 直播教室(LiveRoom)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsLiveRoomDA : clsCommBase4DA
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
 return clsLiveRoomEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsLiveRoomEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLiveRoomEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsLiveRoomEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsLiveRoomEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_LiveRoom(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTable_LiveRoom)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LiveRoom where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LiveRoom where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from LiveRoom where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} LiveRoom.* from LiveRoom Left Join {1} on {2} where {3} and LiveRoom.LiveRoomID not in (Select top {5} LiveRoom.LiveRoomID from LiveRoom Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LiveRoom where {1} and LiveRoomID not in (Select top {2} LiveRoomID from LiveRoom where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LiveRoom where {1} and LiveRoomID not in (Select top {3} LiveRoomID from LiveRoom where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsLiveRoomDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} LiveRoom.* from LiveRoom Left Join {1} on {2} where {3} and LiveRoom.LiveRoomID not in (Select top {5} LiveRoom.LiveRoomID from LiveRoom Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from LiveRoom where {1} and LiveRoomID not in (Select top {2} LiveRoomID from LiveRoom where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from LiveRoom where {1} and LiveRoomID not in (Select top {3} LiveRoomID from LiveRoom where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsLiveRoomEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsLiveRoomDA:GetObjLst)", objException.Message));
}
List<clsLiveRoomEN> arrObjLst = new List<clsLiveRoomEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLiveRoomEN objLiveRoomEN = new clsLiveRoomEN();
try
{
objLiveRoomEN.LiveRoomID = TransNullToInt(objRow[conLiveRoom.LiveRoomID].ToString().Trim()); //房间ID
objLiveRoomEN.RoomName = objRow[conLiveRoom.RoomName].ToString().Trim(); //房间名称
objLiveRoomEN.LiveCode = objRow[conLiveRoom.LiveCode] == DBNull.Value ? null : objRow[conLiveRoom.LiveCode].ToString().Trim(); //直播代码
objLiveRoomEN.School = objRow[conLiveRoom.School].ToString().Trim(); //School
objLiveRoomEN.Link = objRow[conLiveRoom.Link] == DBNull.Value ? null : objRow[conLiveRoom.Link].ToString().Trim(); //相应链接
objLiveRoomEN.PublishSite = objRow[conLiveRoom.PublishSite] == DBNull.Value ? null : objRow[conLiveRoom.PublishSite].ToString().Trim(); //发布点
objLiveRoomEN.VideoName = objRow[conLiveRoom.VideoName] == DBNull.Value ? null : objRow[conLiveRoom.VideoName].ToString().Trim(); //视频名称
objLiveRoomEN.CourseContent = objRow[conLiveRoom.CourseContent] == DBNull.Value ? null : objRow[conLiveRoom.CourseContent].ToString().Trim(); //授课内容
objLiveRoomEN.Instructors = objRow[conLiveRoom.Instructors] == DBNull.Value ? null : objRow[conLiveRoom.Instructors].ToString().Trim(); //授课教师
objLiveRoomEN.IsOpen = TransNullToBool(objRow[conLiveRoom.IsOpen].ToString().Trim()); //是否公开
objLiveRoomEN.Memo = objRow[conLiveRoom.Memo] == DBNull.Value ? null : objRow[conLiveRoom.Memo].ToString().Trim(); //备注
objLiveRoomEN.LiveRoomSite = objRow[conLiveRoom.LiveRoomSite] == DBNull.Value ? null : objRow[conLiveRoom.LiveRoomSite].ToString().Trim(); //LiveRoomSite
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLiveRoomDA: GetObjLst)", objException.Message));
}
objLiveRoomEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLiveRoomEN);
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
public List<clsLiveRoomEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsLiveRoomDA:GetObjLstByTabName)", objException.Message));
}
List<clsLiveRoomEN> arrObjLst = new List<clsLiveRoomEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLiveRoomEN objLiveRoomEN = new clsLiveRoomEN();
try
{
objLiveRoomEN.LiveRoomID = TransNullToInt(objRow[conLiveRoom.LiveRoomID].ToString().Trim()); //房间ID
objLiveRoomEN.RoomName = objRow[conLiveRoom.RoomName].ToString().Trim(); //房间名称
objLiveRoomEN.LiveCode = objRow[conLiveRoom.LiveCode] == DBNull.Value ? null : objRow[conLiveRoom.LiveCode].ToString().Trim(); //直播代码
objLiveRoomEN.School = objRow[conLiveRoom.School].ToString().Trim(); //School
objLiveRoomEN.Link = objRow[conLiveRoom.Link] == DBNull.Value ? null : objRow[conLiveRoom.Link].ToString().Trim(); //相应链接
objLiveRoomEN.PublishSite = objRow[conLiveRoom.PublishSite] == DBNull.Value ? null : objRow[conLiveRoom.PublishSite].ToString().Trim(); //发布点
objLiveRoomEN.VideoName = objRow[conLiveRoom.VideoName] == DBNull.Value ? null : objRow[conLiveRoom.VideoName].ToString().Trim(); //视频名称
objLiveRoomEN.CourseContent = objRow[conLiveRoom.CourseContent] == DBNull.Value ? null : objRow[conLiveRoom.CourseContent].ToString().Trim(); //授课内容
objLiveRoomEN.Instructors = objRow[conLiveRoom.Instructors] == DBNull.Value ? null : objRow[conLiveRoom.Instructors].ToString().Trim(); //授课教师
objLiveRoomEN.IsOpen = TransNullToBool(objRow[conLiveRoom.IsOpen].ToString().Trim()); //是否公开
objLiveRoomEN.Memo = objRow[conLiveRoom.Memo] == DBNull.Value ? null : objRow[conLiveRoom.Memo].ToString().Trim(); //备注
objLiveRoomEN.LiveRoomSite = objRow[conLiveRoom.LiveRoomSite] == DBNull.Value ? null : objRow[conLiveRoom.LiveRoomSite].ToString().Trim(); //LiveRoomSite
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLiveRoomDA: GetObjLst)", objException.Message));
}
objLiveRoomEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLiveRoomEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetLiveRoom(ref clsLiveRoomEN objLiveRoomEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where LiveRoomID = " + ""+ objLiveRoomEN.LiveRoomID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objLiveRoomEN.LiveRoomID = TransNullToInt(objDT.Rows[0][conLiveRoom.LiveRoomID].ToString().Trim()); //房间ID(字段类型:bigint,字段长度:8,是否可空:True)
 objLiveRoomEN.RoomName = objDT.Rows[0][conLiveRoom.RoomName].ToString().Trim(); //房间名称(字段类型:varchar,字段长度:50,是否可空:True)
 objLiveRoomEN.LiveCode = objDT.Rows[0][conLiveRoom.LiveCode].ToString().Trim(); //直播代码(字段类型:varchar,字段长度:100,是否可空:True)
 objLiveRoomEN.School = objDT.Rows[0][conLiveRoom.School].ToString().Trim(); //School(字段类型:varchar,字段长度:50,是否可空:True)
 objLiveRoomEN.Link = objDT.Rows[0][conLiveRoom.Link].ToString().Trim(); //相应链接(字段类型:varchar,字段长度:200,是否可空:True)
 objLiveRoomEN.PublishSite = objDT.Rows[0][conLiveRoom.PublishSite].ToString().Trim(); //发布点(字段类型:varchar,字段长度:50,是否可空:True)
 objLiveRoomEN.VideoName = objDT.Rows[0][conLiveRoom.VideoName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:True)
 objLiveRoomEN.CourseContent = objDT.Rows[0][conLiveRoom.CourseContent].ToString().Trim(); //授课内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objLiveRoomEN.Instructors = objDT.Rows[0][conLiveRoom.Instructors].ToString().Trim(); //授课教师(字段类型:varchar,字段长度:20,是否可空:True)
 objLiveRoomEN.IsOpen = TransNullToBool(objDT.Rows[0][conLiveRoom.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objLiveRoomEN.Memo = objDT.Rows[0][conLiveRoom.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objLiveRoomEN.LiveRoomSite = objDT.Rows[0][conLiveRoom.LiveRoomSite].ToString().Trim(); //LiveRoomSite(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsLiveRoomDA: GetLiveRoom)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngLiveRoomID">表关键字</param>
 /// <returns>表对象</returns>
public clsLiveRoomEN GetObjByLiveRoomID(long lngLiveRoomID)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where LiveRoomID = " + ""+ lngLiveRoomID+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsLiveRoomEN objLiveRoomEN = new clsLiveRoomEN();
try
{
 objLiveRoomEN.LiveRoomID = Int32.Parse(objRow[conLiveRoom.LiveRoomID].ToString().Trim()); //房间ID(字段类型:bigint,字段长度:8,是否可空:True)
 objLiveRoomEN.RoomName = objRow[conLiveRoom.RoomName].ToString().Trim(); //房间名称(字段类型:varchar,字段长度:50,是否可空:True)
 objLiveRoomEN.LiveCode = objRow[conLiveRoom.LiveCode] == DBNull.Value ? null : objRow[conLiveRoom.LiveCode].ToString().Trim(); //直播代码(字段类型:varchar,字段长度:100,是否可空:True)
 objLiveRoomEN.School = objRow[conLiveRoom.School].ToString().Trim(); //School(字段类型:varchar,字段长度:50,是否可空:True)
 objLiveRoomEN.Link = objRow[conLiveRoom.Link] == DBNull.Value ? null : objRow[conLiveRoom.Link].ToString().Trim(); //相应链接(字段类型:varchar,字段长度:200,是否可空:True)
 objLiveRoomEN.PublishSite = objRow[conLiveRoom.PublishSite] == DBNull.Value ? null : objRow[conLiveRoom.PublishSite].ToString().Trim(); //发布点(字段类型:varchar,字段长度:50,是否可空:True)
 objLiveRoomEN.VideoName = objRow[conLiveRoom.VideoName] == DBNull.Value ? null : objRow[conLiveRoom.VideoName].ToString().Trim(); //视频名称(字段类型:varchar,字段长度:100,是否可空:True)
 objLiveRoomEN.CourseContent = objRow[conLiveRoom.CourseContent] == DBNull.Value ? null : objRow[conLiveRoom.CourseContent].ToString().Trim(); //授课内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objLiveRoomEN.Instructors = objRow[conLiveRoom.Instructors] == DBNull.Value ? null : objRow[conLiveRoom.Instructors].ToString().Trim(); //授课教师(字段类型:varchar,字段长度:20,是否可空:True)
 objLiveRoomEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conLiveRoom.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objLiveRoomEN.Memo = objRow[conLiveRoom.Memo] == DBNull.Value ? null : objRow[conLiveRoom.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objLiveRoomEN.LiveRoomSite = objRow[conLiveRoom.LiveRoomSite] == DBNull.Value ? null : objRow[conLiveRoom.LiveRoomSite].ToString().Trim(); //LiveRoomSite(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsLiveRoomDA: GetObjByLiveRoomID)", objException.Message));
}
return objLiveRoomEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsLiveRoomEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsLiveRoomDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsLiveRoomEN objLiveRoomEN = new clsLiveRoomEN()
{
LiveRoomID = TransNullToInt(objRow[conLiveRoom.LiveRoomID].ToString().Trim()), //房间ID
RoomName = objRow[conLiveRoom.RoomName].ToString().Trim(), //房间名称
LiveCode = objRow[conLiveRoom.LiveCode] == DBNull.Value ? null : objRow[conLiveRoom.LiveCode].ToString().Trim(), //直播代码
School = objRow[conLiveRoom.School].ToString().Trim(), //School
Link = objRow[conLiveRoom.Link] == DBNull.Value ? null : objRow[conLiveRoom.Link].ToString().Trim(), //相应链接
PublishSite = objRow[conLiveRoom.PublishSite] == DBNull.Value ? null : objRow[conLiveRoom.PublishSite].ToString().Trim(), //发布点
VideoName = objRow[conLiveRoom.VideoName] == DBNull.Value ? null : objRow[conLiveRoom.VideoName].ToString().Trim(), //视频名称
CourseContent = objRow[conLiveRoom.CourseContent] == DBNull.Value ? null : objRow[conLiveRoom.CourseContent].ToString().Trim(), //授课内容
Instructors = objRow[conLiveRoom.Instructors] == DBNull.Value ? null : objRow[conLiveRoom.Instructors].ToString().Trim(), //授课教师
IsOpen = TransNullToBool(objRow[conLiveRoom.IsOpen].ToString().Trim()), //是否公开
Memo = objRow[conLiveRoom.Memo] == DBNull.Value ? null : objRow[conLiveRoom.Memo].ToString().Trim(), //备注
LiveRoomSite = objRow[conLiveRoom.LiveRoomSite] == DBNull.Value ? null : objRow[conLiveRoom.LiveRoomSite].ToString().Trim() //LiveRoomSite
};
objLiveRoomEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLiveRoomEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsLiveRoomDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsLiveRoomEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLiveRoomEN objLiveRoomEN = new clsLiveRoomEN();
try
{
objLiveRoomEN.LiveRoomID = TransNullToInt(objRow[conLiveRoom.LiveRoomID].ToString().Trim()); //房间ID
objLiveRoomEN.RoomName = objRow[conLiveRoom.RoomName].ToString().Trim(); //房间名称
objLiveRoomEN.LiveCode = objRow[conLiveRoom.LiveCode] == DBNull.Value ? null : objRow[conLiveRoom.LiveCode].ToString().Trim(); //直播代码
objLiveRoomEN.School = objRow[conLiveRoom.School].ToString().Trim(); //School
objLiveRoomEN.Link = objRow[conLiveRoom.Link] == DBNull.Value ? null : objRow[conLiveRoom.Link].ToString().Trim(); //相应链接
objLiveRoomEN.PublishSite = objRow[conLiveRoom.PublishSite] == DBNull.Value ? null : objRow[conLiveRoom.PublishSite].ToString().Trim(); //发布点
objLiveRoomEN.VideoName = objRow[conLiveRoom.VideoName] == DBNull.Value ? null : objRow[conLiveRoom.VideoName].ToString().Trim(); //视频名称
objLiveRoomEN.CourseContent = objRow[conLiveRoom.CourseContent] == DBNull.Value ? null : objRow[conLiveRoom.CourseContent].ToString().Trim(); //授课内容
objLiveRoomEN.Instructors = objRow[conLiveRoom.Instructors] == DBNull.Value ? null : objRow[conLiveRoom.Instructors].ToString().Trim(); //授课教师
objLiveRoomEN.IsOpen = TransNullToBool(objRow[conLiveRoom.IsOpen].ToString().Trim()); //是否公开
objLiveRoomEN.Memo = objRow[conLiveRoom.Memo] == DBNull.Value ? null : objRow[conLiveRoom.Memo].ToString().Trim(); //备注
objLiveRoomEN.LiveRoomSite = objRow[conLiveRoom.LiveRoomSite] == DBNull.Value ? null : objRow[conLiveRoom.LiveRoomSite].ToString().Trim(); //LiveRoomSite
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsLiveRoomDA: GetObjByDataRowLiveRoom)", objException.Message));
}
objLiveRoomEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLiveRoomEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsLiveRoomEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLiveRoomEN objLiveRoomEN = new clsLiveRoomEN();
try
{
objLiveRoomEN.LiveRoomID = TransNullToInt(objRow[conLiveRoom.LiveRoomID].ToString().Trim()); //房间ID
objLiveRoomEN.RoomName = objRow[conLiveRoom.RoomName].ToString().Trim(); //房间名称
objLiveRoomEN.LiveCode = objRow[conLiveRoom.LiveCode] == DBNull.Value ? null : objRow[conLiveRoom.LiveCode].ToString().Trim(); //直播代码
objLiveRoomEN.School = objRow[conLiveRoom.School].ToString().Trim(); //School
objLiveRoomEN.Link = objRow[conLiveRoom.Link] == DBNull.Value ? null : objRow[conLiveRoom.Link].ToString().Trim(); //相应链接
objLiveRoomEN.PublishSite = objRow[conLiveRoom.PublishSite] == DBNull.Value ? null : objRow[conLiveRoom.PublishSite].ToString().Trim(); //发布点
objLiveRoomEN.VideoName = objRow[conLiveRoom.VideoName] == DBNull.Value ? null : objRow[conLiveRoom.VideoName].ToString().Trim(); //视频名称
objLiveRoomEN.CourseContent = objRow[conLiveRoom.CourseContent] == DBNull.Value ? null : objRow[conLiveRoom.CourseContent].ToString().Trim(); //授课内容
objLiveRoomEN.Instructors = objRow[conLiveRoom.Instructors] == DBNull.Value ? null : objRow[conLiveRoom.Instructors].ToString().Trim(); //授课教师
objLiveRoomEN.IsOpen = TransNullToBool(objRow[conLiveRoom.IsOpen].ToString().Trim()); //是否公开
objLiveRoomEN.Memo = objRow[conLiveRoom.Memo] == DBNull.Value ? null : objRow[conLiveRoom.Memo].ToString().Trim(); //备注
objLiveRoomEN.LiveRoomSite = objRow[conLiveRoom.LiveRoomSite] == DBNull.Value ? null : objRow[conLiveRoom.LiveRoomSite].ToString().Trim(); //LiveRoomSite
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsLiveRoomDA: GetObjByDataRow)", objException.Message));
}
objLiveRoomEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLiveRoomEN;
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
objSQL = clsLiveRoomDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLiveRoomEN._CurrTabName, conLiveRoom.LiveRoomID, 8, "");
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
objSQL = clsLiveRoomDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLiveRoomEN._CurrTabName, conLiveRoom.LiveRoomID, 8, strPrefix);
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
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select LiveRoomID from LiveRoom where " + strCondition;
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
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select LiveRoomID from LiveRoom where " + strCondition;
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
 /// <param name = "lngLiveRoomID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngLiveRoomID)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("LiveRoom", "LiveRoomID = " + ""+ lngLiveRoomID+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsLiveRoomDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("LiveRoom", strCondition))
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
objSQL = clsLiveRoomDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("LiveRoom");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsLiveRoomEN objLiveRoomEN)
 {
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiveRoomEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "LiveRoom");
objRow = objDS.Tables["LiveRoom"].NewRow();
objRow[conLiveRoom.RoomName] = objLiveRoomEN.RoomName; //房间名称
 if (objLiveRoomEN.LiveCode !=  "")
 {
objRow[conLiveRoom.LiveCode] = objLiveRoomEN.LiveCode; //直播代码
 }
objRow[conLiveRoom.School] = objLiveRoomEN.School; //School
 if (objLiveRoomEN.Link !=  "")
 {
objRow[conLiveRoom.Link] = objLiveRoomEN.Link; //相应链接
 }
 if (objLiveRoomEN.PublishSite !=  "")
 {
objRow[conLiveRoom.PublishSite] = objLiveRoomEN.PublishSite; //发布点
 }
 if (objLiveRoomEN.VideoName !=  "")
 {
objRow[conLiveRoom.VideoName] = objLiveRoomEN.VideoName; //视频名称
 }
 if (objLiveRoomEN.CourseContent !=  "")
 {
objRow[conLiveRoom.CourseContent] = objLiveRoomEN.CourseContent; //授课内容
 }
 if (objLiveRoomEN.Instructors !=  "")
 {
objRow[conLiveRoom.Instructors] = objLiveRoomEN.Instructors; //授课教师
 }
objRow[conLiveRoom.IsOpen] = objLiveRoomEN.IsOpen; //是否公开
 if (objLiveRoomEN.Memo !=  "")
 {
objRow[conLiveRoom.Memo] = objLiveRoomEN.Memo; //备注
 }
 if (objLiveRoomEN.LiveRoomSite !=  "")
 {
objRow[conLiveRoom.LiveRoomSite] = objLiveRoomEN.LiveRoomSite; //LiveRoomSite
 }
objDS.Tables[clsLiveRoomEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsLiveRoomEN._CurrTabName);
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
 /// <param name = "objLiveRoomEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLiveRoomEN objLiveRoomEN)
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiveRoomEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLiveRoomEN.RoomName !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.RoomName);
 var strRoomName = objLiveRoomEN.RoomName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoomName + "'");
 }
 
 if (objLiveRoomEN.LiveCode !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.LiveCode);
 var strLiveCode = objLiveRoomEN.LiveCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveCode + "'");
 }
 
 if (objLiveRoomEN.School !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.School);
 var strSchool = objLiveRoomEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchool + "'");
 }
 
 if (objLiveRoomEN.Link !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Link);
 var strLink = objLiveRoomEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLink + "'");
 }
 
 if (objLiveRoomEN.PublishSite !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.PublishSite);
 var strPublishSite = objLiveRoomEN.PublishSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPublishSite + "'");
 }
 
 if (objLiveRoomEN.VideoName !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.VideoName);
 var strVideoName = objLiveRoomEN.VideoName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoName + "'");
 }
 
 if (objLiveRoomEN.CourseContent !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.CourseContent);
 var strCourseContent = objLiveRoomEN.CourseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseContent + "'");
 }
 
 if (objLiveRoomEN.Instructors !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Instructors);
 var strInstructors = objLiveRoomEN.Instructors.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInstructors + "'");
 }
 
 arrFieldListForInsert.Add(conLiveRoom.IsOpen);
 arrValueListForInsert.Add("'" + (objLiveRoomEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 if (objLiveRoomEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Memo);
 var strMemo = objLiveRoomEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objLiveRoomEN.LiveRoomSite !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.LiveRoomSite);
 var strLiveRoomSite = objLiveRoomEN.LiveRoomSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveRoomSite + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LiveRoom");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLiveRoomEN objLiveRoomEN)
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiveRoomEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLiveRoomEN.RoomName !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.RoomName);
 var strRoomName = objLiveRoomEN.RoomName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoomName + "'");
 }
 
 if (objLiveRoomEN.LiveCode !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.LiveCode);
 var strLiveCode = objLiveRoomEN.LiveCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveCode + "'");
 }
 
 if (objLiveRoomEN.School !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.School);
 var strSchool = objLiveRoomEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchool + "'");
 }
 
 if (objLiveRoomEN.Link !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Link);
 var strLink = objLiveRoomEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLink + "'");
 }
 
 if (objLiveRoomEN.PublishSite !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.PublishSite);
 var strPublishSite = objLiveRoomEN.PublishSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPublishSite + "'");
 }
 
 if (objLiveRoomEN.VideoName !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.VideoName);
 var strVideoName = objLiveRoomEN.VideoName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoName + "'");
 }
 
 if (objLiveRoomEN.CourseContent !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.CourseContent);
 var strCourseContent = objLiveRoomEN.CourseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseContent + "'");
 }
 
 if (objLiveRoomEN.Instructors !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Instructors);
 var strInstructors = objLiveRoomEN.Instructors.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInstructors + "'");
 }
 
 arrFieldListForInsert.Add(conLiveRoom.IsOpen);
 arrValueListForInsert.Add("'" + (objLiveRoomEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 if (objLiveRoomEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Memo);
 var strMemo = objLiveRoomEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objLiveRoomEN.LiveRoomSite !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.LiveRoomSite);
 var strLiveRoomSite = objLiveRoomEN.LiveRoomSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveRoomSite + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LiveRoom");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLiveRoomEN objLiveRoomEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiveRoomEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLiveRoomEN.RoomName !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.RoomName);
 var strRoomName = objLiveRoomEN.RoomName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoomName + "'");
 }
 
 if (objLiveRoomEN.LiveCode !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.LiveCode);
 var strLiveCode = objLiveRoomEN.LiveCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveCode + "'");
 }
 
 if (objLiveRoomEN.School !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.School);
 var strSchool = objLiveRoomEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchool + "'");
 }
 
 if (objLiveRoomEN.Link !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Link);
 var strLink = objLiveRoomEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLink + "'");
 }
 
 if (objLiveRoomEN.PublishSite !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.PublishSite);
 var strPublishSite = objLiveRoomEN.PublishSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPublishSite + "'");
 }
 
 if (objLiveRoomEN.VideoName !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.VideoName);
 var strVideoName = objLiveRoomEN.VideoName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoName + "'");
 }
 
 if (objLiveRoomEN.CourseContent !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.CourseContent);
 var strCourseContent = objLiveRoomEN.CourseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseContent + "'");
 }
 
 if (objLiveRoomEN.Instructors !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Instructors);
 var strInstructors = objLiveRoomEN.Instructors.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInstructors + "'");
 }
 
 arrFieldListForInsert.Add(conLiveRoom.IsOpen);
 arrValueListForInsert.Add("'" + (objLiveRoomEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 if (objLiveRoomEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Memo);
 var strMemo = objLiveRoomEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objLiveRoomEN.LiveRoomSite !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.LiveRoomSite);
 var strLiveRoomSite = objLiveRoomEN.LiveRoomSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveRoomSite + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LiveRoom");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objLiveRoomEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLiveRoomEN objLiveRoomEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLiveRoomEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLiveRoomEN.RoomName !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.RoomName);
 var strRoomName = objLiveRoomEN.RoomName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoomName + "'");
 }
 
 if (objLiveRoomEN.LiveCode !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.LiveCode);
 var strLiveCode = objLiveRoomEN.LiveCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveCode + "'");
 }
 
 if (objLiveRoomEN.School !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.School);
 var strSchool = objLiveRoomEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchool + "'");
 }
 
 if (objLiveRoomEN.Link !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Link);
 var strLink = objLiveRoomEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLink + "'");
 }
 
 if (objLiveRoomEN.PublishSite !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.PublishSite);
 var strPublishSite = objLiveRoomEN.PublishSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPublishSite + "'");
 }
 
 if (objLiveRoomEN.VideoName !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.VideoName);
 var strVideoName = objLiveRoomEN.VideoName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoName + "'");
 }
 
 if (objLiveRoomEN.CourseContent !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.CourseContent);
 var strCourseContent = objLiveRoomEN.CourseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseContent + "'");
 }
 
 if (objLiveRoomEN.Instructors !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Instructors);
 var strInstructors = objLiveRoomEN.Instructors.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInstructors + "'");
 }
 
 arrFieldListForInsert.Add(conLiveRoom.IsOpen);
 arrValueListForInsert.Add("'" + (objLiveRoomEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 if (objLiveRoomEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.Memo);
 var strMemo = objLiveRoomEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objLiveRoomEN.LiveRoomSite !=  null)
 {
 arrFieldListForInsert.Add(conLiveRoom.LiveRoomSite);
 var strLiveRoomSite = objLiveRoomEN.LiveRoomSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveRoomSite + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into LiveRoom");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewLiveRooms(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where LiveRoomID = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "LiveRoom");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngLiveRoomID = TransNullToInt(oRow[conLiveRoom.LiveRoomID].ToString().Trim());
if (IsExist(lngLiveRoomID))
{
 string strResult = "关键字变量值为:" + string.Format("LiveRoomID = {0}", lngLiveRoomID) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsLiveRoomEN._CurrTabName ].NewRow();
objRow[conLiveRoom.RoomName] = oRow[conLiveRoom.RoomName].ToString().Trim(); //房间名称
objRow[conLiveRoom.LiveCode] = oRow[conLiveRoom.LiveCode].ToString().Trim(); //直播代码
objRow[conLiveRoom.School] = oRow[conLiveRoom.School].ToString().Trim(); //School
objRow[conLiveRoom.Link] = oRow[conLiveRoom.Link].ToString().Trim(); //相应链接
objRow[conLiveRoom.PublishSite] = oRow[conLiveRoom.PublishSite].ToString().Trim(); //发布点
objRow[conLiveRoom.VideoName] = oRow[conLiveRoom.VideoName].ToString().Trim(); //视频名称
objRow[conLiveRoom.CourseContent] = oRow[conLiveRoom.CourseContent].ToString().Trim(); //授课内容
objRow[conLiveRoom.Instructors] = oRow[conLiveRoom.Instructors].ToString().Trim(); //授课教师
objRow[conLiveRoom.IsOpen] = oRow[conLiveRoom.IsOpen].ToString().Trim(); //是否公开
objRow[conLiveRoom.Memo] = oRow[conLiveRoom.Memo].ToString().Trim(); //备注
objRow[conLiveRoom.LiveRoomSite] = oRow[conLiveRoom.LiveRoomSite].ToString().Trim(); //LiveRoomSite
 objDS.Tables[clsLiveRoomEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsLiveRoomEN._CurrTabName);
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
 /// <param name = "objLiveRoomEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsLiveRoomEN objLiveRoomEN)
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiveRoomEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
strSQL = "Select * from LiveRoom where LiveRoomID = " + ""+ objLiveRoomEN.LiveRoomID+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsLiveRoomEN._CurrTabName);
if (objDS.Tables[clsLiveRoomEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:LiveRoomID = " + ""+ objLiveRoomEN.LiveRoomID+"");
return false;
}
objRow = objDS.Tables[clsLiveRoomEN._CurrTabName].Rows[0];
 if (objLiveRoomEN.IsUpdated(conLiveRoom.RoomName))
 {
objRow[conLiveRoom.RoomName] = objLiveRoomEN.RoomName; //房间名称
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveCode))
 {
objRow[conLiveRoom.LiveCode] = objLiveRoomEN.LiveCode; //直播代码
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.School))
 {
objRow[conLiveRoom.School] = objLiveRoomEN.School; //School
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Link))
 {
objRow[conLiveRoom.Link] = objLiveRoomEN.Link; //相应链接
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.PublishSite))
 {
objRow[conLiveRoom.PublishSite] = objLiveRoomEN.PublishSite; //发布点
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.VideoName))
 {
objRow[conLiveRoom.VideoName] = objLiveRoomEN.VideoName; //视频名称
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.CourseContent))
 {
objRow[conLiveRoom.CourseContent] = objLiveRoomEN.CourseContent; //授课内容
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Instructors))
 {
objRow[conLiveRoom.Instructors] = objLiveRoomEN.Instructors; //授课教师
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.IsOpen))
 {
objRow[conLiveRoom.IsOpen] = objLiveRoomEN.IsOpen; //是否公开
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Memo))
 {
objRow[conLiveRoom.Memo] = objLiveRoomEN.Memo; //备注
 }
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveRoomSite))
 {
objRow[conLiveRoom.LiveRoomSite] = objLiveRoomEN.LiveRoomSite; //LiveRoomSite
 }
try
{
objDA.Update(objDS, clsLiveRoomEN._CurrTabName);
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
 /// <param name = "objLiveRoomEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLiveRoomEN objLiveRoomEN)
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiveRoomEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update LiveRoom Set ");
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.RoomName))
 {
 if (objLiveRoomEN.RoomName !=  null)
 {
 var strRoomName = objLiveRoomEN.RoomName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoomName, conLiveRoom.RoomName); //房间名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.RoomName); //房间名称
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveCode))
 {
 if (objLiveRoomEN.LiveCode !=  null)
 {
 var strLiveCode = objLiveRoomEN.LiveCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiveCode, conLiveRoom.LiveCode); //直播代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.LiveCode); //直播代码
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.School))
 {
 if (objLiveRoomEN.School !=  null)
 {
 var strSchool = objLiveRoomEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchool, conLiveRoom.School); //School
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.School); //School
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Link))
 {
 if (objLiveRoomEN.Link !=  null)
 {
 var strLink = objLiveRoomEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLink, conLiveRoom.Link); //相应链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.Link); //相应链接
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.PublishSite))
 {
 if (objLiveRoomEN.PublishSite !=  null)
 {
 var strPublishSite = objLiveRoomEN.PublishSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPublishSite, conLiveRoom.PublishSite); //发布点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.PublishSite); //发布点
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.VideoName))
 {
 if (objLiveRoomEN.VideoName !=  null)
 {
 var strVideoName = objLiveRoomEN.VideoName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoName, conLiveRoom.VideoName); //视频名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.VideoName); //视频名称
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.CourseContent))
 {
 if (objLiveRoomEN.CourseContent !=  null)
 {
 var strCourseContent = objLiveRoomEN.CourseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseContent, conLiveRoom.CourseContent); //授课内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.CourseContent); //授课内容
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Instructors))
 {
 if (objLiveRoomEN.Instructors !=  null)
 {
 var strInstructors = objLiveRoomEN.Instructors.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInstructors, conLiveRoom.Instructors); //授课教师
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.Instructors); //授课教师
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.IsOpen))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objLiveRoomEN.IsOpen == true?"1":"0", conLiveRoom.IsOpen); //是否公开
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Memo))
 {
 if (objLiveRoomEN.Memo !=  null)
 {
 var strMemo = objLiveRoomEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conLiveRoom.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.Memo); //备注
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveRoomSite))
 {
 if (objLiveRoomEN.LiveRoomSite !=  null)
 {
 var strLiveRoomSite = objLiveRoomEN.LiveRoomSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiveRoomSite, conLiveRoom.LiveRoomSite); //LiveRoomSite
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.LiveRoomSite); //LiveRoomSite
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LiveRoomID = {0}", objLiveRoomEN.LiveRoomID); 
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
 /// <param name = "objLiveRoomEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsLiveRoomEN objLiveRoomEN, string strCondition)
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiveRoomEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LiveRoom Set ");
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.RoomName))
 {
 if (objLiveRoomEN.RoomName !=  null)
 {
 var strRoomName = objLiveRoomEN.RoomName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoomName = '{0}',", strRoomName); //房间名称
 }
 else
 {
 sbSQL.Append(" RoomName = null,"); //房间名称
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveCode))
 {
 if (objLiveRoomEN.LiveCode !=  null)
 {
 var strLiveCode = objLiveRoomEN.LiveCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiveCode = '{0}',", strLiveCode); //直播代码
 }
 else
 {
 sbSQL.Append(" LiveCode = null,"); //直播代码
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.School))
 {
 if (objLiveRoomEN.School !=  null)
 {
 var strSchool = objLiveRoomEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" School = '{0}',", strSchool); //School
 }
 else
 {
 sbSQL.Append(" School = null,"); //School
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Link))
 {
 if (objLiveRoomEN.Link !=  null)
 {
 var strLink = objLiveRoomEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Link = '{0}',", strLink); //相应链接
 }
 else
 {
 sbSQL.Append(" Link = null,"); //相应链接
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.PublishSite))
 {
 if (objLiveRoomEN.PublishSite !=  null)
 {
 var strPublishSite = objLiveRoomEN.PublishSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PublishSite = '{0}',", strPublishSite); //发布点
 }
 else
 {
 sbSQL.Append(" PublishSite = null,"); //发布点
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.VideoName))
 {
 if (objLiveRoomEN.VideoName !=  null)
 {
 var strVideoName = objLiveRoomEN.VideoName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoName = '{0}',", strVideoName); //视频名称
 }
 else
 {
 sbSQL.Append(" VideoName = null,"); //视频名称
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.CourseContent))
 {
 if (objLiveRoomEN.CourseContent !=  null)
 {
 var strCourseContent = objLiveRoomEN.CourseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseContent = '{0}',", strCourseContent); //授课内容
 }
 else
 {
 sbSQL.Append(" CourseContent = null,"); //授课内容
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Instructors))
 {
 if (objLiveRoomEN.Instructors !=  null)
 {
 var strInstructors = objLiveRoomEN.Instructors.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Instructors = '{0}',", strInstructors); //授课教师
 }
 else
 {
 sbSQL.Append(" Instructors = null,"); //授课教师
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.IsOpen))
 {
 sbSQL.AppendFormat(" IsOpen = '{0}',", objLiveRoomEN.IsOpen == true?"1":"0"); //是否公开
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Memo))
 {
 if (objLiveRoomEN.Memo !=  null)
 {
 var strMemo = objLiveRoomEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveRoomSite))
 {
 if (objLiveRoomEN.LiveRoomSite !=  null)
 {
 var strLiveRoomSite = objLiveRoomEN.LiveRoomSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiveRoomSite = '{0}',", strLiveRoomSite); //LiveRoomSite
 }
 else
 {
 sbSQL.Append(" LiveRoomSite = null,"); //LiveRoomSite
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
 /// <param name = "objLiveRoomEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsLiveRoomEN objLiveRoomEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiveRoomEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LiveRoom Set ");
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.RoomName))
 {
 if (objLiveRoomEN.RoomName !=  null)
 {
 var strRoomName = objLiveRoomEN.RoomName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoomName = '{0}',", strRoomName); //房间名称
 }
 else
 {
 sbSQL.Append(" RoomName = null,"); //房间名称
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveCode))
 {
 if (objLiveRoomEN.LiveCode !=  null)
 {
 var strLiveCode = objLiveRoomEN.LiveCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiveCode = '{0}',", strLiveCode); //直播代码
 }
 else
 {
 sbSQL.Append(" LiveCode = null,"); //直播代码
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.School))
 {
 if (objLiveRoomEN.School !=  null)
 {
 var strSchool = objLiveRoomEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" School = '{0}',", strSchool); //School
 }
 else
 {
 sbSQL.Append(" School = null,"); //School
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Link))
 {
 if (objLiveRoomEN.Link !=  null)
 {
 var strLink = objLiveRoomEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Link = '{0}',", strLink); //相应链接
 }
 else
 {
 sbSQL.Append(" Link = null,"); //相应链接
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.PublishSite))
 {
 if (objLiveRoomEN.PublishSite !=  null)
 {
 var strPublishSite = objLiveRoomEN.PublishSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PublishSite = '{0}',", strPublishSite); //发布点
 }
 else
 {
 sbSQL.Append(" PublishSite = null,"); //发布点
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.VideoName))
 {
 if (objLiveRoomEN.VideoName !=  null)
 {
 var strVideoName = objLiveRoomEN.VideoName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoName = '{0}',", strVideoName); //视频名称
 }
 else
 {
 sbSQL.Append(" VideoName = null,"); //视频名称
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.CourseContent))
 {
 if (objLiveRoomEN.CourseContent !=  null)
 {
 var strCourseContent = objLiveRoomEN.CourseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseContent = '{0}',", strCourseContent); //授课内容
 }
 else
 {
 sbSQL.Append(" CourseContent = null,"); //授课内容
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Instructors))
 {
 if (objLiveRoomEN.Instructors !=  null)
 {
 var strInstructors = objLiveRoomEN.Instructors.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Instructors = '{0}',", strInstructors); //授课教师
 }
 else
 {
 sbSQL.Append(" Instructors = null,"); //授课教师
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.IsOpen))
 {
 sbSQL.AppendFormat(" IsOpen = '{0}',", objLiveRoomEN.IsOpen == true?"1":"0"); //是否公开
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Memo))
 {
 if (objLiveRoomEN.Memo !=  null)
 {
 var strMemo = objLiveRoomEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveRoomSite))
 {
 if (objLiveRoomEN.LiveRoomSite !=  null)
 {
 var strLiveRoomSite = objLiveRoomEN.LiveRoomSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiveRoomSite = '{0}',", strLiveRoomSite); //LiveRoomSite
 }
 else
 {
 sbSQL.Append(" LiveRoomSite = null,"); //LiveRoomSite
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
 /// <param name = "objLiveRoomEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLiveRoomEN objLiveRoomEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLiveRoomEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLiveRoomEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update LiveRoom Set ");
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.RoomName))
 {
 if (objLiveRoomEN.RoomName !=  null)
 {
 var strRoomName = objLiveRoomEN.RoomName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoomName, conLiveRoom.RoomName); //房间名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.RoomName); //房间名称
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveCode))
 {
 if (objLiveRoomEN.LiveCode !=  null)
 {
 var strLiveCode = objLiveRoomEN.LiveCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiveCode, conLiveRoom.LiveCode); //直播代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.LiveCode); //直播代码
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.School))
 {
 if (objLiveRoomEN.School !=  null)
 {
 var strSchool = objLiveRoomEN.School.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchool, conLiveRoom.School); //School
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.School); //School
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Link))
 {
 if (objLiveRoomEN.Link !=  null)
 {
 var strLink = objLiveRoomEN.Link.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLink, conLiveRoom.Link); //相应链接
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.Link); //相应链接
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.PublishSite))
 {
 if (objLiveRoomEN.PublishSite !=  null)
 {
 var strPublishSite = objLiveRoomEN.PublishSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPublishSite, conLiveRoom.PublishSite); //发布点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.PublishSite); //发布点
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.VideoName))
 {
 if (objLiveRoomEN.VideoName !=  null)
 {
 var strVideoName = objLiveRoomEN.VideoName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoName, conLiveRoom.VideoName); //视频名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.VideoName); //视频名称
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.CourseContent))
 {
 if (objLiveRoomEN.CourseContent !=  null)
 {
 var strCourseContent = objLiveRoomEN.CourseContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseContent, conLiveRoom.CourseContent); //授课内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.CourseContent); //授课内容
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Instructors))
 {
 if (objLiveRoomEN.Instructors !=  null)
 {
 var strInstructors = objLiveRoomEN.Instructors.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInstructors, conLiveRoom.Instructors); //授课教师
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.Instructors); //授课教师
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.IsOpen))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objLiveRoomEN.IsOpen == true?"1":"0", conLiveRoom.IsOpen); //是否公开
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.Memo))
 {
 if (objLiveRoomEN.Memo !=  null)
 {
 var strMemo = objLiveRoomEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conLiveRoom.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.Memo); //备注
 }
 }
 
 if (objLiveRoomEN.IsUpdated(conLiveRoom.LiveRoomSite))
 {
 if (objLiveRoomEN.LiveRoomSite !=  null)
 {
 var strLiveRoomSite = objLiveRoomEN.LiveRoomSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiveRoomSite, conLiveRoom.LiveRoomSite); //LiveRoomSite
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLiveRoom.LiveRoomSite); //LiveRoomSite
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where LiveRoomID = {0}", objLiveRoomEN.LiveRoomID); 
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
 /// <param name = "lngLiveRoomID">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngLiveRoomID) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngLiveRoomID,
};
 objSQL.ExecSP("LiveRoom_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngLiveRoomID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngLiveRoomID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
//删除LiveRoom本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LiveRoom where LiveRoomID = " + ""+ lngLiveRoomID+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelLiveRoom(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
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
//删除LiveRoom本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LiveRoom where LiveRoomID in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngLiveRoomID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngLiveRoomID) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
//删除LiveRoom本表中与当前对象有关的记录
strSQL = strSQL + "Delete from LiveRoom where LiveRoomID = " + ""+ lngLiveRoomID+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelLiveRoom(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsLiveRoomDA: DelLiveRoom)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from LiveRoom where " + strCondition ;
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
public bool DelLiveRoomWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsLiveRoomDA: DelLiveRoomWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from LiveRoom where " + strCondition ;
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
 /// <param name = "objLiveRoomENS">源对象</param>
 /// <param name = "objLiveRoomENT">目标对象</param>
public void CopyTo(clsLiveRoomEN objLiveRoomENS, clsLiveRoomEN objLiveRoomENT)
{
objLiveRoomENT.LiveRoomID = objLiveRoomENS.LiveRoomID; //房间ID
objLiveRoomENT.RoomName = objLiveRoomENS.RoomName; //房间名称
objLiveRoomENT.LiveCode = objLiveRoomENS.LiveCode; //直播代码
objLiveRoomENT.School = objLiveRoomENS.School; //School
objLiveRoomENT.Link = objLiveRoomENS.Link; //相应链接
objLiveRoomENT.PublishSite = objLiveRoomENS.PublishSite; //发布点
objLiveRoomENT.VideoName = objLiveRoomENS.VideoName; //视频名称
objLiveRoomENT.CourseContent = objLiveRoomENS.CourseContent; //授课内容
objLiveRoomENT.Instructors = objLiveRoomENS.Instructors; //授课教师
objLiveRoomENT.IsOpen = objLiveRoomENS.IsOpen; //是否公开
objLiveRoomENT.Memo = objLiveRoomENS.Memo; //备注
objLiveRoomENT.LiveRoomSite = objLiveRoomENS.LiveRoomSite; //LiveRoomSite
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsLiveRoomEN objLiveRoomEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objLiveRoomEN.RoomName, conLiveRoom.RoomName);
clsCheckSql.CheckFieldNotNull(objLiveRoomEN.School, conLiveRoom.School);
//检查字段长度
clsCheckSql.CheckFieldLen(objLiveRoomEN.RoomName, 50, conLiveRoom.RoomName);
clsCheckSql.CheckFieldLen(objLiveRoomEN.LiveCode, 100, conLiveRoom.LiveCode);
clsCheckSql.CheckFieldLen(objLiveRoomEN.School, 50, conLiveRoom.School);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Link, 200, conLiveRoom.Link);
clsCheckSql.CheckFieldLen(objLiveRoomEN.PublishSite, 50, conLiveRoom.PublishSite);
clsCheckSql.CheckFieldLen(objLiveRoomEN.VideoName, 100, conLiveRoom.VideoName);
clsCheckSql.CheckFieldLen(objLiveRoomEN.CourseContent, 8000, conLiveRoom.CourseContent);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Instructors, 20, conLiveRoom.Instructors);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Memo, 1000, conLiveRoom.Memo);
clsCheckSql.CheckFieldLen(objLiveRoomEN.LiveRoomSite, 100, conLiveRoom.LiveRoomSite);
//检查字段外键固定长度
 objLiveRoomEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsLiveRoomEN objLiveRoomEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLiveRoomEN.RoomName, 50, conLiveRoom.RoomName);
clsCheckSql.CheckFieldLen(objLiveRoomEN.LiveCode, 100, conLiveRoom.LiveCode);
clsCheckSql.CheckFieldLen(objLiveRoomEN.School, 50, conLiveRoom.School);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Link, 200, conLiveRoom.Link);
clsCheckSql.CheckFieldLen(objLiveRoomEN.PublishSite, 50, conLiveRoom.PublishSite);
clsCheckSql.CheckFieldLen(objLiveRoomEN.VideoName, 100, conLiveRoom.VideoName);
clsCheckSql.CheckFieldLen(objLiveRoomEN.CourseContent, 8000, conLiveRoom.CourseContent);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Instructors, 20, conLiveRoom.Instructors);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Memo, 1000, conLiveRoom.Memo);
clsCheckSql.CheckFieldLen(objLiveRoomEN.LiveRoomSite, 100, conLiveRoom.LiveRoomSite);
//检查外键字段长度
 objLiveRoomEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsLiveRoomEN objLiveRoomEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLiveRoomEN.RoomName, 50, conLiveRoom.RoomName);
clsCheckSql.CheckFieldLen(objLiveRoomEN.LiveCode, 100, conLiveRoom.LiveCode);
clsCheckSql.CheckFieldLen(objLiveRoomEN.School, 50, conLiveRoom.School);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Link, 200, conLiveRoom.Link);
clsCheckSql.CheckFieldLen(objLiveRoomEN.PublishSite, 50, conLiveRoom.PublishSite);
clsCheckSql.CheckFieldLen(objLiveRoomEN.VideoName, 100, conLiveRoom.VideoName);
clsCheckSql.CheckFieldLen(objLiveRoomEN.CourseContent, 8000, conLiveRoom.CourseContent);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Instructors, 20, conLiveRoom.Instructors);
clsCheckSql.CheckFieldLen(objLiveRoomEN.Memo, 1000, conLiveRoom.Memo);
clsCheckSql.CheckFieldLen(objLiveRoomEN.LiveRoomSite, 100, conLiveRoom.LiveRoomSite);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.RoomName, conLiveRoom.RoomName);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.LiveCode, conLiveRoom.LiveCode);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.School, conLiveRoom.School);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.Link, conLiveRoom.Link);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.PublishSite, conLiveRoom.PublishSite);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.VideoName, conLiveRoom.VideoName);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.CourseContent, conLiveRoom.CourseContent);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.Instructors, conLiveRoom.Instructors);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.Memo, conLiveRoom.Memo);
clsCheckSql.CheckSqlInjection4Field(objLiveRoomEN.LiveRoomSite, conLiveRoom.LiveRoomSite);
//检查外键字段长度
 objLiveRoomEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--LiveRoom(直播教室),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objLiveRoomEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsLiveRoomEN objLiveRoomEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objLiveRoomEN.LiveRoomSite == null)
{
 sbCondition.AppendFormat(" and LiveRoomSite is null");
}
else
{
 sbCondition.AppendFormat(" and LiveRoomSite = '{0}'", objLiveRoomEN.LiveRoomSite);
}
 sbCondition.AppendFormat(" and School = '{0}'", objLiveRoomEN.School);
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
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
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
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
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
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLiveRoomEN._CurrTabName);
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
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLiveRoomEN._CurrTabName, strCondition);
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
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
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
 objSQL = clsLiveRoomDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}