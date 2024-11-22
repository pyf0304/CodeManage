
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPointDA
 表名:vUserPoint(01120306)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:位置管理(PointManage)
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
 /// v用户点位(vUserPoint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUserPointDA : clsCommBase4DA
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
 return clsvUserPointEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUserPointEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserPointEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUserPointEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUserPointEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPointId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPointId)
{
strPointId = strPointId.Replace("'", "''");
if (strPointId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vUserPoint中,检查关键字,长度不正确!(clsvUserPointDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPointId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vUserPoint中,关键字不能为空 或 null!(clsvUserPointDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvUserPointDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
strSQL = "Select * from vUserPoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUserPoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTable_vUserPoint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
strSQL = "Select * from vUserPoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
strSQL = "Select * from vUserPoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserPoint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserPoint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUserPoint where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUserPoint.* from vUserPoint Left Join {1} on {2} where {3} and vUserPoint.PointId not in (Select top {5} vUserPoint.PointId from vUserPoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserPoint where {1} and PointId not in (Select top {2} PointId from vUserPoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserPoint where {1} and PointId not in (Select top {3} PointId from vUserPoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUserPointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUserPoint.* from vUserPoint Left Join {1} on {2} where {3} and vUserPoint.PointId not in (Select top {5} vUserPoint.PointId from vUserPoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserPoint where {1} and PointId not in (Select top {2} PointId from vUserPoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserPoint where {1} and PointId not in (Select top {3} PointId from vUserPoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUserPointEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUserPointDA:GetObjLst)", objException.Message));
}
List<clsvUserPointEN> arrObjLst = new List<clsvUserPointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
strSQL = "Select * from vUserPoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPointEN objvUserPointEN = new clsvUserPointEN();
try
{
objvUserPointEN.PointId = objRow[convUserPoint.PointId].ToString().Trim(); //点位Id
objvUserPointEN.UserId = objRow[convUserPoint.UserId] == DBNull.Value ? null : objRow[convUserPoint.UserId].ToString().Trim(); //用户ID
objvUserPointEN.UserName = objRow[convUserPoint.UserName] == DBNull.Value ? null : objRow[convUserPoint.UserName].ToString().Trim(); //用户名
objvUserPointEN.UserStateId = objRow[convUserPoint.UserStateId] == DBNull.Value ? null : objRow[convUserPoint.UserStateId].ToString().Trim(); //用户状态Id
objvUserPointEN.UserStateName = objRow[convUserPoint.UserStateName] == DBNull.Value ? null : objRow[convUserPoint.UserStateName].ToString().Trim(); //用户状态名
objvUserPointEN.IdXzCollege = objRow[convUserPoint.IdXzCollege] == DBNull.Value ? null : objRow[convUserPoint.IdXzCollege].ToString().Trim(); //学院流水号
objvUserPointEN.CollegeNameA = objRow[convUserPoint.CollegeNameA] == DBNull.Value ? null : objRow[convUserPoint.CollegeNameA].ToString().Trim(); //学院名称简写
objvUserPointEN.IdentityID = objRow[convUserPoint.IdentityID].ToString().Trim(); //身份编号
objvUserPointEN.IdentityDesc = objRow[convUserPoint.IdentityDesc].ToString().Trim(); //身份描述
objvUserPointEN.Longitude = objRow[convUserPoint.Longitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Longitude].ToString().Trim()); //经度
objvUserPointEN.Latitude = objRow[convUserPoint.Latitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Latitude].ToString().Trim()); //纬度
objvUserPointEN.Address = objRow[convUserPoint.Address] == DBNull.Value ? null : objRow[convUserPoint.Address].ToString().Trim(); //地址
objvUserPointEN.UpdDate = objRow[convUserPoint.UpdDate].ToString().Trim(); //修改日期
objvUserPointEN.Memo = objRow[convUserPoint.Memo] == DBNull.Value ? null : objRow[convUserPoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserPointDA: GetObjLst)", objException.Message));
}
objvUserPointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserPointEN);
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
public List<clsvUserPointEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUserPointDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUserPointEN> arrObjLst = new List<clsvUserPointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPointEN objvUserPointEN = new clsvUserPointEN();
try
{
objvUserPointEN.PointId = objRow[convUserPoint.PointId].ToString().Trim(); //点位Id
objvUserPointEN.UserId = objRow[convUserPoint.UserId] == DBNull.Value ? null : objRow[convUserPoint.UserId].ToString().Trim(); //用户ID
objvUserPointEN.UserName = objRow[convUserPoint.UserName] == DBNull.Value ? null : objRow[convUserPoint.UserName].ToString().Trim(); //用户名
objvUserPointEN.UserStateId = objRow[convUserPoint.UserStateId] == DBNull.Value ? null : objRow[convUserPoint.UserStateId].ToString().Trim(); //用户状态Id
objvUserPointEN.UserStateName = objRow[convUserPoint.UserStateName] == DBNull.Value ? null : objRow[convUserPoint.UserStateName].ToString().Trim(); //用户状态名
objvUserPointEN.IdXzCollege = objRow[convUserPoint.IdXzCollege] == DBNull.Value ? null : objRow[convUserPoint.IdXzCollege].ToString().Trim(); //学院流水号
objvUserPointEN.CollegeNameA = objRow[convUserPoint.CollegeNameA] == DBNull.Value ? null : objRow[convUserPoint.CollegeNameA].ToString().Trim(); //学院名称简写
objvUserPointEN.IdentityID = objRow[convUserPoint.IdentityID].ToString().Trim(); //身份编号
objvUserPointEN.IdentityDesc = objRow[convUserPoint.IdentityDesc].ToString().Trim(); //身份描述
objvUserPointEN.Longitude = objRow[convUserPoint.Longitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Longitude].ToString().Trim()); //经度
objvUserPointEN.Latitude = objRow[convUserPoint.Latitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Latitude].ToString().Trim()); //纬度
objvUserPointEN.Address = objRow[convUserPoint.Address] == DBNull.Value ? null : objRow[convUserPoint.Address].ToString().Trim(); //地址
objvUserPointEN.UpdDate = objRow[convUserPoint.UpdDate].ToString().Trim(); //修改日期
objvUserPointEN.Memo = objRow[convUserPoint.Memo] == DBNull.Value ? null : objRow[convUserPoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserPointDA: GetObjLst)", objException.Message));
}
objvUserPointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserPointEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUserPointEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUserPoint(ref clsvUserPointEN objvUserPointEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
strSQL = "Select * from vUserPoint where PointId = " + "'"+ objvUserPointEN.PointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUserPointEN.PointId = objDT.Rows[0][convUserPoint.PointId].ToString().Trim(); //点位Id(字段类型:char,字段长度:10,是否可空:False)
 objvUserPointEN.UserId = objDT.Rows[0][convUserPoint.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserPointEN.UserName = objDT.Rows[0][convUserPoint.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserPointEN.UserStateId = objDT.Rows[0][convUserPoint.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:True)
 objvUserPointEN.UserStateName = objDT.Rows[0][convUserPoint.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserPointEN.IdXzCollege = objDT.Rows[0][convUserPoint.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvUserPointEN.CollegeNameA = objDT.Rows[0][convUserPoint.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvUserPointEN.IdentityID = objDT.Rows[0][convUserPoint.IdentityID].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvUserPointEN.IdentityDesc = objDT.Rows[0][convUserPoint.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvUserPointEN.Longitude = TransNullToDouble(objDT.Rows[0][convUserPoint.Longitude].ToString().Trim()); //经度(字段类型:decimal,字段长度:12,是否可空:True)
 objvUserPointEN.Latitude = TransNullToDouble(objDT.Rows[0][convUserPoint.Latitude].ToString().Trim()); //纬度(字段类型:decimal,字段长度:12,是否可空:True)
 objvUserPointEN.Address = objDT.Rows[0][convUserPoint.Address].ToString().Trim(); //地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvUserPointEN.UpdDate = objDT.Rows[0][convUserPoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserPointEN.Memo = objDT.Rows[0][convUserPoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUserPointDA: GetvUserPoint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPointId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUserPointEN GetObjByPointId(string strPointId)
{
CheckPrimaryKey(strPointId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
strSQL = "Select * from vUserPoint where PointId = " + "'"+ strPointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUserPointEN objvUserPointEN = new clsvUserPointEN();
try
{
 objvUserPointEN.PointId = objRow[convUserPoint.PointId].ToString().Trim(); //点位Id(字段类型:char,字段长度:10,是否可空:False)
 objvUserPointEN.UserId = objRow[convUserPoint.UserId] == DBNull.Value ? null : objRow[convUserPoint.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserPointEN.UserName = objRow[convUserPoint.UserName] == DBNull.Value ? null : objRow[convUserPoint.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserPointEN.UserStateId = objRow[convUserPoint.UserStateId] == DBNull.Value ? null : objRow[convUserPoint.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:True)
 objvUserPointEN.UserStateName = objRow[convUserPoint.UserStateName] == DBNull.Value ? null : objRow[convUserPoint.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserPointEN.IdXzCollege = objRow[convUserPoint.IdXzCollege] == DBNull.Value ? null : objRow[convUserPoint.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvUserPointEN.CollegeNameA = objRow[convUserPoint.CollegeNameA] == DBNull.Value ? null : objRow[convUserPoint.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvUserPointEN.IdentityID = objRow[convUserPoint.IdentityID].ToString().Trim(); //身份编号(字段类型:char,字段长度:2,是否可空:False)
 objvUserPointEN.IdentityDesc = objRow[convUserPoint.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvUserPointEN.Longitude = objRow[convUserPoint.Longitude] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserPoint.Longitude].ToString().Trim()); //经度(字段类型:decimal,字段长度:12,是否可空:True)
 objvUserPointEN.Latitude = objRow[convUserPoint.Latitude] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convUserPoint.Latitude].ToString().Trim()); //纬度(字段类型:decimal,字段长度:12,是否可空:True)
 objvUserPointEN.Address = objRow[convUserPoint.Address] == DBNull.Value ? null : objRow[convUserPoint.Address].ToString().Trim(); //地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvUserPointEN.UpdDate = objRow[convUserPoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserPointEN.Memo = objRow[convUserPoint.Memo] == DBNull.Value ? null : objRow[convUserPoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUserPointDA: GetObjByPointId)", objException.Message));
}
return objvUserPointEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUserPointEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUserPointDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
strSQL = "Select * from vUserPoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUserPointEN objvUserPointEN = new clsvUserPointEN()
{
PointId = objRow[convUserPoint.PointId].ToString().Trim(), //点位Id
UserId = objRow[convUserPoint.UserId] == DBNull.Value ? null : objRow[convUserPoint.UserId].ToString().Trim(), //用户ID
UserName = objRow[convUserPoint.UserName] == DBNull.Value ? null : objRow[convUserPoint.UserName].ToString().Trim(), //用户名
UserStateId = objRow[convUserPoint.UserStateId] == DBNull.Value ? null : objRow[convUserPoint.UserStateId].ToString().Trim(), //用户状态Id
UserStateName = objRow[convUserPoint.UserStateName] == DBNull.Value ? null : objRow[convUserPoint.UserStateName].ToString().Trim(), //用户状态名
IdXzCollege = objRow[convUserPoint.IdXzCollege] == DBNull.Value ? null : objRow[convUserPoint.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convUserPoint.CollegeNameA] == DBNull.Value ? null : objRow[convUserPoint.CollegeNameA].ToString().Trim(), //学院名称简写
IdentityID = objRow[convUserPoint.IdentityID].ToString().Trim(), //身份编号
IdentityDesc = objRow[convUserPoint.IdentityDesc].ToString().Trim(), //身份描述
Longitude = objRow[convUserPoint.Longitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Longitude].ToString().Trim()), //经度
Latitude = objRow[convUserPoint.Latitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Latitude].ToString().Trim()), //纬度
Address = objRow[convUserPoint.Address] == DBNull.Value ? null : objRow[convUserPoint.Address].ToString().Trim(), //地址
UpdDate = objRow[convUserPoint.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convUserPoint.Memo] == DBNull.Value ? null : objRow[convUserPoint.Memo].ToString().Trim() //备注
};
objvUserPointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserPointEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUserPointDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUserPointEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserPointEN objvUserPointEN = new clsvUserPointEN();
try
{
objvUserPointEN.PointId = objRow[convUserPoint.PointId].ToString().Trim(); //点位Id
objvUserPointEN.UserId = objRow[convUserPoint.UserId] == DBNull.Value ? null : objRow[convUserPoint.UserId].ToString().Trim(); //用户ID
objvUserPointEN.UserName = objRow[convUserPoint.UserName] == DBNull.Value ? null : objRow[convUserPoint.UserName].ToString().Trim(); //用户名
objvUserPointEN.UserStateId = objRow[convUserPoint.UserStateId] == DBNull.Value ? null : objRow[convUserPoint.UserStateId].ToString().Trim(); //用户状态Id
objvUserPointEN.UserStateName = objRow[convUserPoint.UserStateName] == DBNull.Value ? null : objRow[convUserPoint.UserStateName].ToString().Trim(); //用户状态名
objvUserPointEN.IdXzCollege = objRow[convUserPoint.IdXzCollege] == DBNull.Value ? null : objRow[convUserPoint.IdXzCollege].ToString().Trim(); //学院流水号
objvUserPointEN.CollegeNameA = objRow[convUserPoint.CollegeNameA] == DBNull.Value ? null : objRow[convUserPoint.CollegeNameA].ToString().Trim(); //学院名称简写
objvUserPointEN.IdentityID = objRow[convUserPoint.IdentityID].ToString().Trim(); //身份编号
objvUserPointEN.IdentityDesc = objRow[convUserPoint.IdentityDesc].ToString().Trim(); //身份描述
objvUserPointEN.Longitude = objRow[convUserPoint.Longitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Longitude].ToString().Trim()); //经度
objvUserPointEN.Latitude = objRow[convUserPoint.Latitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Latitude].ToString().Trim()); //纬度
objvUserPointEN.Address = objRow[convUserPoint.Address] == DBNull.Value ? null : objRow[convUserPoint.Address].ToString().Trim(); //地址
objvUserPointEN.UpdDate = objRow[convUserPoint.UpdDate].ToString().Trim(); //修改日期
objvUserPointEN.Memo = objRow[convUserPoint.Memo] == DBNull.Value ? null : objRow[convUserPoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUserPointDA: GetObjByDataRowvUserPoint)", objException.Message));
}
objvUserPointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserPointEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUserPointEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserPointEN objvUserPointEN = new clsvUserPointEN();
try
{
objvUserPointEN.PointId = objRow[convUserPoint.PointId].ToString().Trim(); //点位Id
objvUserPointEN.UserId = objRow[convUserPoint.UserId] == DBNull.Value ? null : objRow[convUserPoint.UserId].ToString().Trim(); //用户ID
objvUserPointEN.UserName = objRow[convUserPoint.UserName] == DBNull.Value ? null : objRow[convUserPoint.UserName].ToString().Trim(); //用户名
objvUserPointEN.UserStateId = objRow[convUserPoint.UserStateId] == DBNull.Value ? null : objRow[convUserPoint.UserStateId].ToString().Trim(); //用户状态Id
objvUserPointEN.UserStateName = objRow[convUserPoint.UserStateName] == DBNull.Value ? null : objRow[convUserPoint.UserStateName].ToString().Trim(); //用户状态名
objvUserPointEN.IdXzCollege = objRow[convUserPoint.IdXzCollege] == DBNull.Value ? null : objRow[convUserPoint.IdXzCollege].ToString().Trim(); //学院流水号
objvUserPointEN.CollegeNameA = objRow[convUserPoint.CollegeNameA] == DBNull.Value ? null : objRow[convUserPoint.CollegeNameA].ToString().Trim(); //学院名称简写
objvUserPointEN.IdentityID = objRow[convUserPoint.IdentityID].ToString().Trim(); //身份编号
objvUserPointEN.IdentityDesc = objRow[convUserPoint.IdentityDesc].ToString().Trim(); //身份描述
objvUserPointEN.Longitude = objRow[convUserPoint.Longitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Longitude].ToString().Trim()); //经度
objvUserPointEN.Latitude = objRow[convUserPoint.Latitude] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convUserPoint.Latitude].ToString().Trim()); //纬度
objvUserPointEN.Address = objRow[convUserPoint.Address] == DBNull.Value ? null : objRow[convUserPoint.Address].ToString().Trim(); //地址
objvUserPointEN.UpdDate = objRow[convUserPoint.UpdDate].ToString().Trim(); //修改日期
objvUserPointEN.Memo = objRow[convUserPoint.Memo] == DBNull.Value ? null : objRow[convUserPoint.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUserPointDA: GetObjByDataRow)", objException.Message));
}
objvUserPointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserPointEN;
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
objSQL = clsvUserPointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserPointEN._CurrTabName, convUserPoint.PointId, 10, "");
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
objSQL = clsvUserPointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserPointEN._CurrTabName, convUserPoint.PointId, 10, strPrefix);
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
 objSQL = clsvUserPointDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PointId from vUserPoint where " + strCondition;
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
 objSQL = clsvUserPointDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PointId from vUserPoint where " + strCondition;
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
 /// <param name = "strPointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPointId)
{
CheckPrimaryKey(strPointId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserPoint", "PointId = " + "'"+ strPointId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUserPointDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserPoint", strCondition))
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
objSQL = clsvUserPointDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUserPoint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUserPointENS">源对象</param>
 /// <param name = "objvUserPointENT">目标对象</param>
public void CopyTo(clsvUserPointEN objvUserPointENS, clsvUserPointEN objvUserPointENT)
{
objvUserPointENT.PointId = objvUserPointENS.PointId; //点位Id
objvUserPointENT.UserId = objvUserPointENS.UserId; //用户ID
objvUserPointENT.UserName = objvUserPointENS.UserName; //用户名
objvUserPointENT.UserStateId = objvUserPointENS.UserStateId; //用户状态Id
objvUserPointENT.UserStateName = objvUserPointENS.UserStateName; //用户状态名
objvUserPointENT.IdXzCollege = objvUserPointENS.IdXzCollege; //学院流水号
objvUserPointENT.CollegeNameA = objvUserPointENS.CollegeNameA; //学院名称简写
objvUserPointENT.IdentityID = objvUserPointENS.IdentityID; //身份编号
objvUserPointENT.IdentityDesc = objvUserPointENS.IdentityDesc; //身份描述
objvUserPointENT.Longitude = objvUserPointENS.Longitude; //经度
objvUserPointENT.Latitude = objvUserPointENS.Latitude; //纬度
objvUserPointENT.Address = objvUserPointENS.Address; //地址
objvUserPointENT.UpdDate = objvUserPointENS.UpdDate; //修改日期
objvUserPointENT.Memo = objvUserPointENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUserPointEN objvUserPointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUserPointEN.PointId, 10, convUserPoint.PointId);
clsCheckSql.CheckFieldLen(objvUserPointEN.UserId, 18, convUserPoint.UserId);
clsCheckSql.CheckFieldLen(objvUserPointEN.UserName, 30, convUserPoint.UserName);
clsCheckSql.CheckFieldLen(objvUserPointEN.UserStateId, 2, convUserPoint.UserStateId);
clsCheckSql.CheckFieldLen(objvUserPointEN.UserStateName, 20, convUserPoint.UserStateName);
clsCheckSql.CheckFieldLen(objvUserPointEN.IdXzCollege, 4, convUserPoint.IdXzCollege);
clsCheckSql.CheckFieldLen(objvUserPointEN.CollegeNameA, 12, convUserPoint.CollegeNameA);
clsCheckSql.CheckFieldLen(objvUserPointEN.IdentityID, 2, convUserPoint.IdentityID);
clsCheckSql.CheckFieldLen(objvUserPointEN.IdentityDesc, 20, convUserPoint.IdentityDesc);
clsCheckSql.CheckFieldLen(objvUserPointEN.Address, 200, convUserPoint.Address);
clsCheckSql.CheckFieldLen(objvUserPointEN.UpdDate, 20, convUserPoint.UpdDate);
clsCheckSql.CheckFieldLen(objvUserPointEN.Memo, 1000, convUserPoint.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.PointId, convUserPoint.PointId);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.UserId, convUserPoint.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.UserName, convUserPoint.UserName);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.UserStateId, convUserPoint.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.UserStateName, convUserPoint.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.IdXzCollege, convUserPoint.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.CollegeNameA, convUserPoint.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.IdentityID, convUserPoint.IdentityID);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.IdentityDesc, convUserPoint.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.Address, convUserPoint.Address);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.UpdDate, convUserPoint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvUserPointEN.Memo, convUserPoint.Memo);
//检查外键字段长度
 objvUserPointEN._IsCheckProperty = true;
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
 objSQL = clsvUserPointDA.GetSpecSQLObj();
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
 objSQL = clsvUserPointDA.GetSpecSQLObj();
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
 objSQL = clsvUserPointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserPointEN._CurrTabName);
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
 objSQL = clsvUserPointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserPointEN._CurrTabName, strCondition);
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
 objSQL = clsvUserPointDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}