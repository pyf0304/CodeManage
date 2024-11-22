
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_UserGroupDA
 表名:vzx_UserGroup(01120843)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// vzx_UserGroup(vzx_UserGroup)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_UserGroupDA : clsCommBase4DA
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
 return clsvzx_UserGroupEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_UserGroupEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_UserGroupEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_UserGroupEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_UserGroupEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from vzx_UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_UserGroup(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTable_vzx_UserGroup)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from vzx_UserGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from vzx_UserGroup where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_UserGroup where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_UserGroup where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_UserGroup where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_UserGroup.* from vzx_UserGroup Left Join {1} on {2} where {3} and vzx_UserGroup.mId not in (Select top {5} vzx_UserGroup.mId from vzx_UserGroup Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_UserGroup where {1} and mId not in (Select top {2} mId from vzx_UserGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_UserGroup where {1} and mId not in (Select top {3} mId from vzx_UserGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_UserGroup.* from vzx_UserGroup Left Join {1} on {2} where {3} and vzx_UserGroup.mId not in (Select top {5} vzx_UserGroup.mId from vzx_UserGroup Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_UserGroup where {1} and mId not in (Select top {2} mId from vzx_UserGroup where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_UserGroup where {1} and mId not in (Select top {3} mId from vzx_UserGroup where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_UserGroupEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA:GetObjLst)", objException.Message));
}
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from vzx_UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = TransNullToInt(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_UserGroupDA: GetObjLst)", objException.Message));
}
objvzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_UserGroupEN);
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
public List<clsvzx_UserGroupEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_UserGroupEN> arrObjLst = new List<clsvzx_UserGroupEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = TransNullToInt(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_UserGroupDA: GetObjLst)", objException.Message));
}
objvzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_UserGroupEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_UserGroupEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_UserGroup(ref clsvzx_UserGroupEN objvzx_UserGroupEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from vzx_UserGroup where mId = " + ""+ objvzx_UserGroupEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_UserGroupEN.TopicUserRoleName = objDT.Rows[0][convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_UserGroupEN.mId = TransNullToInt(objDT.Rows[0][convzx_UserGroup.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_UserGroupEN.UserId = objDT.Rows[0][convzx_UserGroup.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_UserGroupEN.UpdDate = objDT.Rows[0][convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_UserGroupEN.UpdUser = objDT.Rows[0][convzx_UserGroup.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_UserGroupEN.Memo = objDT.Rows[0][convzx_UserGroup.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_UserGroupEN.zxTopicUserRoleId = objDT.Rows[0][convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id(字段类型:char,字段长度:4,是否可空:False)
 objvzx_UserGroupEN.GroupTextId = objDT.Rows[0][convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_UserGroupEN.zxColorId = objDT.Rows[0][convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_UserGroupEN.OrderNum = TransNullToInt(objDT.Rows[0][convzx_UserGroup.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_UserGroupEN.ColorCode = objDT.Rows[0][convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_UserGroupEN.UserNo = TransNullToInt(objDT.Rows[0][convzx_UserGroup.UserNo].ToString().Trim()); //用户号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_UserGroupEN.CollegeName = objDT.Rows[0][convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_UserGroupEN.GroupTextName = objDT.Rows[0][convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_UserGroupEN.IdXzCollege = objDT.Rows[0][convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_UserGroupEN.IdXzMajor = objDT.Rows[0][convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_UserGroupEN.MajorName = objDT.Rows[0][convzx_UserGroup.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_UserGroupEN.UserName = objDT.Rows[0][convzx_UserGroup.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_UserGroupDA: Getvzx_UserGroup)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_UserGroupEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from vzx_UserGroup where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
 objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_UserGroupEN.mId = Int32.Parse(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id(字段类型:char,字段长度:4,是否可空:False)
 objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_UserGroupDA: GetObjBymId)", objException.Message));
}
return objvzx_UserGroupEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_UserGroupEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
strSQL = "Select * from vzx_UserGroup where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN()
{
TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(), //主题用户角色
mId = TransNullToInt(objRow[convzx_UserGroup.mId].ToString().Trim()), //mId
UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(), //用户ID
UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(), //备注
zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(), //主键Id
GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(), //小组Id
zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(), //颜色Id
OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.OrderNum].ToString().Trim()), //序号
ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(), //颜色码
UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.UserNo].ToString().Trim()), //用户号
CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(), //学院名称
GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(), //小组名称
IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(), //专业名称
UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim() //用户名
};
objvzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_UserGroupEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_UserGroupDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_UserGroupEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = TransNullToInt(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_UserGroupDA: GetObjByDataRowvzx_UserGroup)", objException.Message));
}
objvzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_UserGroupEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_UserGroupEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_UserGroupEN objvzx_UserGroupEN = new clsvzx_UserGroupEN();
try
{
objvzx_UserGroupEN.TopicUserRoleName = objRow[convzx_UserGroup.TopicUserRoleName] == DBNull.Value ? null : objRow[convzx_UserGroup.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvzx_UserGroupEN.mId = TransNullToInt(objRow[convzx_UserGroup.mId].ToString().Trim()); //mId
objvzx_UserGroupEN.UserId = objRow[convzx_UserGroup.UserId] == DBNull.Value ? null : objRow[convzx_UserGroup.UserId].ToString().Trim(); //用户ID
objvzx_UserGroupEN.UpdDate = objRow[convzx_UserGroup.UpdDate] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdDate].ToString().Trim(); //修改日期
objvzx_UserGroupEN.UpdUser = objRow[convzx_UserGroup.UpdUser] == DBNull.Value ? null : objRow[convzx_UserGroup.UpdUser].ToString().Trim(); //修改人
objvzx_UserGroupEN.Memo = objRow[convzx_UserGroup.Memo] == DBNull.Value ? null : objRow[convzx_UserGroup.Memo].ToString().Trim(); //备注
objvzx_UserGroupEN.zxTopicUserRoleId = objRow[convzx_UserGroup.zxTopicUserRoleId].ToString().Trim(); //主键Id
objvzx_UserGroupEN.GroupTextId = objRow[convzx_UserGroup.GroupTextId] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextId].ToString().Trim(); //小组Id
objvzx_UserGroupEN.zxColorId = objRow[convzx_UserGroup.zxColorId].ToString().Trim(); //颜色Id
objvzx_UserGroupEN.OrderNum = objRow[convzx_UserGroup.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.OrderNum].ToString().Trim()); //序号
objvzx_UserGroupEN.ColorCode = objRow[convzx_UserGroup.ColorCode] == DBNull.Value ? null : objRow[convzx_UserGroup.ColorCode].ToString().Trim(); //颜色码
objvzx_UserGroupEN.UserNo = objRow[convzx_UserGroup.UserNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_UserGroup.UserNo].ToString().Trim()); //用户号
objvzx_UserGroupEN.CollegeName = objRow[convzx_UserGroup.CollegeName] == DBNull.Value ? null : objRow[convzx_UserGroup.CollegeName].ToString().Trim(); //学院名称
objvzx_UserGroupEN.GroupTextName = objRow[convzx_UserGroup.GroupTextName] == DBNull.Value ? null : objRow[convzx_UserGroup.GroupTextName].ToString().Trim(); //小组名称
objvzx_UserGroupEN.IdXzCollege = objRow[convzx_UserGroup.IdXzCollege] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_UserGroupEN.IdXzMajor = objRow[convzx_UserGroup.IdXzMajor] == DBNull.Value ? null : objRow[convzx_UserGroup.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_UserGroupEN.MajorName = objRow[convzx_UserGroup.MajorName] == DBNull.Value ? null : objRow[convzx_UserGroup.MajorName].ToString().Trim(); //专业名称
objvzx_UserGroupEN.UserName = objRow[convzx_UserGroup.UserName] == DBNull.Value ? null : objRow[convzx_UserGroup.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_UserGroupDA: GetObjByDataRow)", objException.Message));
}
objvzx_UserGroupEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_UserGroupEN;
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
objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_UserGroupEN._CurrTabName, convzx_UserGroup.mId, 8, "");
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
objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_UserGroupEN._CurrTabName, convzx_UserGroup.mId, 8, strPrefix);
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
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vzx_UserGroup where " + strCondition;
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
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vzx_UserGroup where " + strCondition;
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
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_UserGroup", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_UserGroupDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_UserGroup", strCondition))
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
objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_UserGroup");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_UserGroupENS">源对象</param>
 /// <param name = "objvzx_UserGroupENT">目标对象</param>
public void CopyTo(clsvzx_UserGroupEN objvzx_UserGroupENS, clsvzx_UserGroupEN objvzx_UserGroupENT)
{
objvzx_UserGroupENT.TopicUserRoleName = objvzx_UserGroupENS.TopicUserRoleName; //主题用户角色
objvzx_UserGroupENT.mId = objvzx_UserGroupENS.mId; //mId
objvzx_UserGroupENT.UserId = objvzx_UserGroupENS.UserId; //用户ID
objvzx_UserGroupENT.UpdDate = objvzx_UserGroupENS.UpdDate; //修改日期
objvzx_UserGroupENT.UpdUser = objvzx_UserGroupENS.UpdUser; //修改人
objvzx_UserGroupENT.Memo = objvzx_UserGroupENS.Memo; //备注
objvzx_UserGroupENT.zxTopicUserRoleId = objvzx_UserGroupENS.zxTopicUserRoleId; //主键Id
objvzx_UserGroupENT.GroupTextId = objvzx_UserGroupENS.GroupTextId; //小组Id
objvzx_UserGroupENT.zxColorId = objvzx_UserGroupENS.zxColorId; //颜色Id
objvzx_UserGroupENT.OrderNum = objvzx_UserGroupENS.OrderNum; //序号
objvzx_UserGroupENT.ColorCode = objvzx_UserGroupENS.ColorCode; //颜色码
objvzx_UserGroupENT.UserNo = objvzx_UserGroupENS.UserNo; //用户号
objvzx_UserGroupENT.CollegeName = objvzx_UserGroupENS.CollegeName; //学院名称
objvzx_UserGroupENT.GroupTextName = objvzx_UserGroupENS.GroupTextName; //小组名称
objvzx_UserGroupENT.IdXzCollege = objvzx_UserGroupENS.IdXzCollege; //学院流水号
objvzx_UserGroupENT.IdXzMajor = objvzx_UserGroupENS.IdXzMajor; //专业流水号
objvzx_UserGroupENT.MajorName = objvzx_UserGroupENS.MajorName; //专业名称
objvzx_UserGroupENT.UserName = objvzx_UserGroupENS.UserName; //用户名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_UserGroupEN objvzx_UserGroupEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.TopicUserRoleName, 100, convzx_UserGroup.TopicUserRoleName);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.UserId, 18, convzx_UserGroup.UserId);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.UpdDate, 20, convzx_UserGroup.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.UpdUser, 20, convzx_UserGroup.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.Memo, 1000, convzx_UserGroup.Memo);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.zxTopicUserRoleId, 4, convzx_UserGroup.zxTopicUserRoleId);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.GroupTextId, 8, convzx_UserGroup.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.zxColorId, 2, convzx_UserGroup.zxColorId);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.ColorCode, 200, convzx_UserGroup.ColorCode);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.CollegeName, 100, convzx_UserGroup.CollegeName);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.GroupTextName, 2000, convzx_UserGroup.GroupTextName);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.IdXzCollege, 4, convzx_UserGroup.IdXzCollege);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.IdXzMajor, 8, convzx_UserGroup.IdXzMajor);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.MajorName, 100, convzx_UserGroup.MajorName);
clsCheckSql.CheckFieldLen(objvzx_UserGroupEN.UserName, 30, convzx_UserGroup.UserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.TopicUserRoleName, convzx_UserGroup.TopicUserRoleName);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.UserId, convzx_UserGroup.UserId);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.UpdDate, convzx_UserGroup.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.UpdUser, convzx_UserGroup.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.Memo, convzx_UserGroup.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.zxTopicUserRoleId, convzx_UserGroup.zxTopicUserRoleId);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.GroupTextId, convzx_UserGroup.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.zxColorId, convzx_UserGroup.zxColorId);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.ColorCode, convzx_UserGroup.ColorCode);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.CollegeName, convzx_UserGroup.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.GroupTextName, convzx_UserGroup.GroupTextName);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.IdXzCollege, convzx_UserGroup.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.IdXzMajor, convzx_UserGroup.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.MajorName, convzx_UserGroup.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvzx_UserGroupEN.UserName, convzx_UserGroup.UserName);
//检查外键字段长度
 objvzx_UserGroupEN._IsCheckProperty = true;
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
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
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
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
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
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_UserGroupEN._CurrTabName);
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
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_UserGroupEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_UserGroupDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}