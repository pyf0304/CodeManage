
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRightDetailDA
 表名:vQxUserRightDetail(01120179)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// v用户权限详细关系(vQxUserRightDetail)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUserRightDetailDA : clsCommBase4DA
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
 return clsvQxUserRightDetailEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUserRightDetailEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserRightDetailEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUserRightDetailEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUserRightDetailEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRightDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUserRightDetail(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTable_vQxUserRightDetail)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRightDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRightDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRightDetail where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRightDetail where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserRightDetail where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserRightDetail.* from vQxUserRightDetail Left Join {1} on {2} where {3} and vQxUserRightDetail.mId not in (Select top {5} vQxUserRightDetail.mId from vQxUserRightDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRightDetail where {1} and mId not in (Select top {2} mId from vQxUserRightDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRightDetail where {1} and mId not in (Select top {3} mId from vQxUserRightDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserRightDetail.* from vQxUserRightDetail Left Join {1} on {2} where {3} and vQxUserRightDetail.mId not in (Select top {5} vQxUserRightDetail.mId from vQxUserRightDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRightDetail where {1} and mId not in (Select top {2} mId from vQxUserRightDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRightDetail where {1} and mId not in (Select top {3} mId from vQxUserRightDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQxUserRightDetailEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA:GetObjLst)", objException.Message));
}
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRightDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = TransNullToInt(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserRightDetailDA: GetObjLst)", objException.Message));
}
objvQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserRightDetailEN);
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
public List<clsvQxUserRightDetailEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = TransNullToInt(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserRightDetailDA: GetObjLst)", objException.Message));
}
objvQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserRightDetailEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUserRightDetail(ref clsvQxUserRightDetailEN objvQxUserRightDetailEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRightDetail where mId = " + ""+ objvQxUserRightDetailEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUserRightDetailEN.mId = TransNullToInt(objDT.Rows[0][convQxUserRightDetail.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvQxUserRightDetailEN.UserId = objDT.Rows[0][convQxUserRightDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxUserRightDetailEN.UserName = objDT.Rows[0][convQxUserRightDetail.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxUserRightDetailEN.IdXzCollege = objDT.Rows[0][convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUserRightDetailEN.CollegeName = objDT.Rows[0][convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserRightDetailEN.CollegeNameA = objDT.Rows[0][convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvQxUserRightDetailEN.IdentityId = objDT.Rows[0][convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRightDetailEN.IdentityDesc = objDT.Rows[0][convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRightDetailEN.StuIdTeacherId = objDT.Rows[0][convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRightDetailEN.RightId = objDT.Rows[0][convQxUserRightDetail.RightId].ToString().Trim(); //权限编号(字段类型:char,字段长度:8,是否可空:False)
 objvQxUserRightDetailEN.RightName = objDT.Rows[0][convQxUserRightDetail.RightName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxUserRightDetailEN.RightTypeId = objDT.Rows[0][convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserRightDetailEN.RightTypeName = objDT.Rows[0][convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUserRightDetailEN.FuncModuleId = objDT.Rows[0][convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvQxUserRightDetailEN.FuncModuleName = objDT.Rows[0][convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRightDetailEN.RightRangeLevelId = objDT.Rows[0][convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRightDetailEN.RightRangeLevelName = objDT.Rows[0][convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRightDetailEN.Authorizer = objDT.Rows[0][convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserRightDetailEN.mKeyId = objDT.Rows[0][convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id(字段类型:varchar,字段长度:10,是否可空:True)
 objvQxUserRightDetailEN.UpdDate = objDT.Rows[0][convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRightDetailEN.UpdUser = objDT.Rows[0][convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRightDetailEN.Memo = objDT.Rows[0][convQxUserRightDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUserRightDetailDA: GetvQxUserRightDetail)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUserRightDetailEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRightDetail where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
 objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号(字段类型:char,字段长度:8,是否可空:False)
 objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人(字段类型:varchar,字段长度:18,是否可空:False)
 objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id(字段类型:varchar,字段长度:10,是否可空:True)
 objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUserRightDetailDA: GetObjBymId)", objException.Message));
}
return objvQxUserRightDetailEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUserRightDetailEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRightDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN()
{
mId = TransNullToInt(objRow[convQxUserRightDetail.mId].ToString().Trim()), //mId
UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(), //用户ID
UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(), //用户名
IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(), //学院名称简写
IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(), //身份Id
IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(), //身份描述
StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(), //学工号
RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(), //权限编号
RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(), //权限名称
RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(), //权限类型编号
RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(), //权限类型名
FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(), //功能模块名称
RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(), //权限范围等级Id
RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(), //权限范围等级名称
Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(), //授权人
mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(), //关键字Id
UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim() //备注
};
objvQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRightDetailEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUserRightDetailDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUserRightDetailEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = TransNullToInt(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUserRightDetailDA: GetObjByDataRowvQxUserRightDetail)", objException.Message));
}
objvQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRightDetailEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUserRightDetailEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = TransNullToInt(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUserRightDetailDA: GetObjByDataRow)", objException.Message));
}
objvQxUserRightDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRightDetailEN;
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
objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserRightDetailEN._CurrTabName, convQxUserRightDetail.mId, 8, "");
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
objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserRightDetailEN._CurrTabName, convQxUserRightDetail.mId, 8, strPrefix);
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
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQxUserRightDetail where " + strCondition;
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
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQxUserRightDetail where " + strCondition;
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
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserRightDetail", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUserRightDetailDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserRightDetail", strCondition))
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
objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUserRightDetail");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUserRightDetailENS">源对象</param>
 /// <param name = "objvQxUserRightDetailENT">目标对象</param>
public void CopyTo(clsvQxUserRightDetailEN objvQxUserRightDetailENS, clsvQxUserRightDetailEN objvQxUserRightDetailENT)
{
objvQxUserRightDetailENT.mId = objvQxUserRightDetailENS.mId; //mId
objvQxUserRightDetailENT.UserId = objvQxUserRightDetailENS.UserId; //用户ID
objvQxUserRightDetailENT.UserName = objvQxUserRightDetailENS.UserName; //用户名
objvQxUserRightDetailENT.IdXzCollege = objvQxUserRightDetailENS.IdXzCollege; //学院流水号
objvQxUserRightDetailENT.CollegeName = objvQxUserRightDetailENS.CollegeName; //学院名称
objvQxUserRightDetailENT.CollegeNameA = objvQxUserRightDetailENS.CollegeNameA; //学院名称简写
objvQxUserRightDetailENT.IdentityId = objvQxUserRightDetailENS.IdentityId; //身份Id
objvQxUserRightDetailENT.IdentityDesc = objvQxUserRightDetailENS.IdentityDesc; //身份描述
objvQxUserRightDetailENT.StuIdTeacherId = objvQxUserRightDetailENS.StuIdTeacherId; //学工号
objvQxUserRightDetailENT.RightId = objvQxUserRightDetailENS.RightId; //权限编号
objvQxUserRightDetailENT.RightName = objvQxUserRightDetailENS.RightName; //权限名称
objvQxUserRightDetailENT.RightTypeId = objvQxUserRightDetailENS.RightTypeId; //权限类型编号
objvQxUserRightDetailENT.RightTypeName = objvQxUserRightDetailENS.RightTypeName; //权限类型名
objvQxUserRightDetailENT.FuncModuleId = objvQxUserRightDetailENS.FuncModuleId; //功能模块Id
objvQxUserRightDetailENT.FuncModuleName = objvQxUserRightDetailENS.FuncModuleName; //功能模块名称
objvQxUserRightDetailENT.RightRangeLevelId = objvQxUserRightDetailENS.RightRangeLevelId; //权限范围等级Id
objvQxUserRightDetailENT.RightRangeLevelName = objvQxUserRightDetailENS.RightRangeLevelName; //权限范围等级名称
objvQxUserRightDetailENT.Authorizer = objvQxUserRightDetailENS.Authorizer; //授权人
objvQxUserRightDetailENT.mKeyId = objvQxUserRightDetailENS.mKeyId; //关键字Id
objvQxUserRightDetailENT.UpdDate = objvQxUserRightDetailENS.UpdDate; //修改日期
objvQxUserRightDetailENT.UpdUser = objvQxUserRightDetailENS.UpdUser; //修改人
objvQxUserRightDetailENT.Memo = objvQxUserRightDetailENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUserRightDetailEN objvQxUserRightDetailEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.UserId, 18, convQxUserRightDetail.UserId);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.UserName, 30, convQxUserRightDetail.UserName);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.IdXzCollege, 4, convQxUserRightDetail.IdXzCollege);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.CollegeName, 100, convQxUserRightDetail.CollegeName);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.CollegeNameA, 12, convQxUserRightDetail.CollegeNameA);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.IdentityId, 2, convQxUserRightDetail.IdentityId);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.IdentityDesc, 20, convQxUserRightDetail.IdentityDesc);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.StuIdTeacherId, 20, convQxUserRightDetail.StuIdTeacherId);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.RightId, 8, convQxUserRightDetail.RightId);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.RightName, 200, convQxUserRightDetail.RightName);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.RightTypeId, 4, convQxUserRightDetail.RightTypeId);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.RightTypeName, 50, convQxUserRightDetail.RightTypeName);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.FuncModuleId, 4, convQxUserRightDetail.FuncModuleId);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.FuncModuleName, 30, convQxUserRightDetail.FuncModuleName);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.RightRangeLevelId, 2, convQxUserRightDetail.RightRangeLevelId);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.RightRangeLevelName, 30, convQxUserRightDetail.RightRangeLevelName);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.Authorizer, 18, convQxUserRightDetail.Authorizer);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.mKeyId, 10, convQxUserRightDetail.mKeyId);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.UpdDate, 20, convQxUserRightDetail.UpdDate);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.UpdUser, 20, convQxUserRightDetail.UpdUser);
clsCheckSql.CheckFieldLen(objvQxUserRightDetailEN.Memo, 1000, convQxUserRightDetail.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.UserId, convQxUserRightDetail.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.UserName, convQxUserRightDetail.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.IdXzCollege, convQxUserRightDetail.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.CollegeName, convQxUserRightDetail.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.CollegeNameA, convQxUserRightDetail.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.IdentityId, convQxUserRightDetail.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.IdentityDesc, convQxUserRightDetail.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.StuIdTeacherId, convQxUserRightDetail.StuIdTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.RightId, convQxUserRightDetail.RightId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.RightName, convQxUserRightDetail.RightName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.RightTypeId, convQxUserRightDetail.RightTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.RightTypeName, convQxUserRightDetail.RightTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.FuncModuleId, convQxUserRightDetail.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.FuncModuleName, convQxUserRightDetail.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.RightRangeLevelId, convQxUserRightDetail.RightRangeLevelId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.RightRangeLevelName, convQxUserRightDetail.RightRangeLevelName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.Authorizer, convQxUserRightDetail.Authorizer);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.mKeyId, convQxUserRightDetail.mKeyId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.UpdDate, convQxUserRightDetail.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.UpdUser, convQxUserRightDetail.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRightDetailEN.Memo, convQxUserRightDetail.Memo);
//检查外键字段长度
 objvQxUserRightDetailEN._IsCheckProperty = true;
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
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserRightDetailEN._CurrTabName);
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
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserRightDetailEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUserRightDetailDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}