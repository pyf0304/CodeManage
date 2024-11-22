﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelationDA
 表名:vQxUserRoleRelation(01120257)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:20:59
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
 /// vQx用户角色关系(vQxUserRoleRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxUserRoleRelationDA : clsCommBase4DA
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
 return clsvQxUserRoleRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxUserRoleRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserRoleRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxUserRoleRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxUserRoleRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxUserRoleRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTable_vQxUserRoleRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserRoleRelation.* from vQxUserRoleRelation Left Join {1} on {2} where {3} and vQxUserRoleRelation.mId not in (Select top {5} vQxUserRoleRelation.mId from vQxUserRoleRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation where {1} and mId not in (Select top {2} mId from vQxUserRoleRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation where {1} and mId not in (Select top {3} mId from vQxUserRoleRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxUserRoleRelation.* from vQxUserRoleRelation Left Join {1} on {2} where {3} and vQxUserRoleRelation.mId not in (Select top {5} vQxUserRoleRelation.mId from vQxUserRoleRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation where {1} and mId not in (Select top {2} mId from vQxUserRoleRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxUserRoleRelation where {1} and mId not in (Select top {3} mId from vQxUserRoleRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQxUserRoleRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA:GetObjLst)", objException.Message));
}
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = TransNullToInt(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //mId
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //QxPrjId
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //PrjName
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名称
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份Id
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //学院名称
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserRoleRelationDA: GetObjLst)", objException.Message));
}
objvQxUserRoleRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
public List<clsvQxUserRoleRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = TransNullToInt(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //mId
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //QxPrjId
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //PrjName
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名称
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份Id
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //学院名称
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxUserRoleRelationDA: GetObjLst)", objException.Message));
}
objvQxUserRoleRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxUserRoleRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxUserRoleRelation(ref clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation where mId = " + ""+ objvQxUserRoleRelationEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxUserRoleRelationEN.mId = TransNullToInt(objDT.Rows[0][convQxUserRoleRelation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvQxUserRoleRelationEN.UserId = objDT.Rows[0][convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxUserRoleRelationEN.RoleId = objDT.Rows[0][convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxUserRoleRelationEN.QxPrjId = objDT.Rows[0][convQxUserRoleRelation.QxPrjId].ToString().Trim(); //QxPrjId(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserRoleRelationEN.Memo = objDT.Rows[0][convQxUserRoleRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxUserRoleRelationEN.PrjName = objDT.Rows[0][convQxUserRoleRelation.PrjName].ToString().Trim(); //PrjName(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxUserRoleRelationEN.RoleName = objDT.Rows[0][convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUserRoleRelationEN.UserName = objDT.Rows[0][convQxUserRoleRelation.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxUserRoleRelationEN.DepartmentId = objDT.Rows[0][convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUserRoleRelationEN.UserStateId = objDT.Rows[0][convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxUserRoleRelationEN.DepartmentName = objDT.Rows[0][convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUserRoleRelationEN.UserStateName = objDT.Rows[0][convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRoleRelationEN.IdentityDesc = objDT.Rows[0][convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelationEN.IdentityId = objDT.Rows[0][convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRoleRelationEN.StuTeacherId = objDT.Rows[0][convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRoleRelationEN.CollegeName = objDT.Rows[0][convQxUserRoleRelation.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserRoleRelationEN.IdXzCollege = objDT.Rows[0][convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUserRoleRelationEN.Password = objDT.Rows[0][convQxUserRoleRelation.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxUserRoleRelationDA: GetvQxUserRoleRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxUserRoleRelationEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
 objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //QxPrjId(字段类型:char,字段长度:4,是否可空:False)
 objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //PrjName(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id(字段类型:varchar,字段长度:8,是否可空:True)
 objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id(字段类型:char,字段长度:2,是否可空:True)
 objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述(字段类型:varchar,字段长度:20,是否可空:False)
 objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxUserRoleRelationDA: GetObjBymId)", objException.Message));
}
return objvQxUserRoleRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxUserRoleRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
strSQL = "Select * from vQxUserRoleRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN()
{
mId = TransNullToInt(objRow[convQxUserRoleRelation.mId].ToString().Trim()), //mId
UserId = objRow[convQxUserRoleRelation.UserId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserId].ToString().Trim(), //用户ID
RoleId = objRow[convQxUserRoleRelation.RoleId].ToString().Trim(), //角色Id
QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(), //QxPrjId
Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(), //备注
PrjName = objRow[convQxUserRoleRelation.PrjName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.PrjName].ToString().Trim(), //PrjName
RoleName = objRow[convQxUserRoleRelation.RoleName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleName].ToString().Trim(), //角色名
UserName = objRow[convQxUserRoleRelation.UserName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convQxUserRoleRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(), //部门Id
UserStateId = objRow[convQxUserRoleRelation.UserStateId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(), //用户状态Id
DepartmentName = objRow[convQxUserRoleRelation.DepartmentName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(), //部门名称
UserStateName = objRow[convQxUserRoleRelation.UserStateName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(), //用户状态名
IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(), //身份描述
IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(), //身份Id
StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(), //学工号
CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(), //学院流水号
Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim() //口令
};
objvQxUserRoleRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRoleRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxUserRoleRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxUserRoleRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = TransNullToInt(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //mId
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //QxPrjId
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //PrjName
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名称
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份Id
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //学院名称
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxUserRoleRelationDA: GetObjByDataRowvQxUserRoleRelation)", objException.Message));
}
objvQxUserRoleRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRoleRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxUserRoleRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = TransNullToInt(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //mId
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //QxPrjId
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //PrjName
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名称
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份Id
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //学院名称
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxUserRoleRelationDA: GetObjByDataRow)", objException.Message));
}
objvQxUserRoleRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxUserRoleRelationEN;
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
objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserRoleRelationEN._CurrTabName, convQxUserRoleRelation.mId, 8, "");
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
objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxUserRoleRelationEN._CurrTabName, convQxUserRoleRelation.mId, 8, strPrefix);
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
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vQxUserRoleRelation where " + strCondition;
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
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vQxUserRoleRelation where " + strCondition;
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
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserRoleRelation", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxUserRoleRelation", strCondition))
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
objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxUserRoleRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationENS">源对象</param>
 /// <param name = "objvQxUserRoleRelationENT">目标对象</param>
public void CopyTo(clsvQxUserRoleRelationEN objvQxUserRoleRelationENS, clsvQxUserRoleRelationEN objvQxUserRoleRelationENT)
{
objvQxUserRoleRelationENT.mId = objvQxUserRoleRelationENS.mId; //mId
objvQxUserRoleRelationENT.UserId = objvQxUserRoleRelationENS.UserId; //用户ID
objvQxUserRoleRelationENT.RoleId = objvQxUserRoleRelationENS.RoleId; //角色Id
objvQxUserRoleRelationENT.QxPrjId = objvQxUserRoleRelationENS.QxPrjId; //QxPrjId
objvQxUserRoleRelationENT.Memo = objvQxUserRoleRelationENS.Memo; //备注
objvQxUserRoleRelationENT.PrjName = objvQxUserRoleRelationENS.PrjName; //PrjName
objvQxUserRoleRelationENT.RoleName = objvQxUserRoleRelationENS.RoleName; //角色名
objvQxUserRoleRelationENT.UserName = objvQxUserRoleRelationENS.UserName; //用户名
objvQxUserRoleRelationENT.DepartmentId = objvQxUserRoleRelationENS.DepartmentId; //部门Id
objvQxUserRoleRelationENT.UserStateId = objvQxUserRoleRelationENS.UserStateId; //用户状态Id
objvQxUserRoleRelationENT.DepartmentName = objvQxUserRoleRelationENS.DepartmentName; //部门名称
objvQxUserRoleRelationENT.UserStateName = objvQxUserRoleRelationENS.UserStateName; //用户状态名
objvQxUserRoleRelationENT.IdentityDesc = objvQxUserRoleRelationENS.IdentityDesc; //身份描述
objvQxUserRoleRelationENT.IdentityId = objvQxUserRoleRelationENS.IdentityId; //身份Id
objvQxUserRoleRelationENT.StuTeacherId = objvQxUserRoleRelationENS.StuTeacherId; //学工号
objvQxUserRoleRelationENT.CollegeName = objvQxUserRoleRelationENS.CollegeName; //学院名称
objvQxUserRoleRelationENT.IdXzCollege = objvQxUserRoleRelationENS.IdXzCollege; //学院流水号
objvQxUserRoleRelationENT.Password = objvQxUserRoleRelationENS.Password; //口令
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.UserId, 18, convQxUserRoleRelation.UserId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.RoleId, 8, convQxUserRoleRelation.RoleId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.QxPrjId, 4, convQxUserRoleRelation.QxPrjId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.Memo, 1000, convQxUserRoleRelation.Memo);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.PrjName, 30, convQxUserRoleRelation.PrjName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.RoleName, 100, convQxUserRoleRelation.RoleName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.UserName, 30, convQxUserRoleRelation.UserName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.DepartmentId, 8, convQxUserRoleRelation.DepartmentId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.UserStateId, 2, convQxUserRoleRelation.UserStateId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.DepartmentName, 100, convQxUserRoleRelation.DepartmentName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.UserStateName, 20, convQxUserRoleRelation.UserStateName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.IdentityDesc, 20, convQxUserRoleRelation.IdentityDesc);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.IdentityId, 2, convQxUserRoleRelation.IdentityId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.StuTeacherId, 20, convQxUserRoleRelation.StuTeacherId);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.CollegeName, 100, convQxUserRoleRelation.CollegeName);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.IdXzCollege, 4, convQxUserRoleRelation.IdXzCollege);
clsCheckSql.CheckFieldLen(objvQxUserRoleRelationEN.Password, 20, convQxUserRoleRelation.Password);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.UserId, convQxUserRoleRelation.UserId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.RoleId, convQxUserRoleRelation.RoleId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.QxPrjId, convQxUserRoleRelation.QxPrjId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.Memo, convQxUserRoleRelation.Memo);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.PrjName, convQxUserRoleRelation.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.RoleName, convQxUserRoleRelation.RoleName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.UserName, convQxUserRoleRelation.UserName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.DepartmentId, convQxUserRoleRelation.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.UserStateId, convQxUserRoleRelation.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.DepartmentName, convQxUserRoleRelation.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.UserStateName, convQxUserRoleRelation.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.IdentityDesc, convQxUserRoleRelation.IdentityDesc);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.IdentityId, convQxUserRoleRelation.IdentityId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.StuTeacherId, convQxUserRoleRelation.StuTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.CollegeName, convQxUserRoleRelation.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.IdXzCollege, convQxUserRoleRelation.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvQxUserRoleRelationEN.Password, convQxUserRoleRelation.Password);
//检查外键字段长度
 objvQxUserRoleRelationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vQxUserRoleRelation(vQx用户角色关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvQxUserRoleRelationEN.mId);
 if (objvQxUserRoleRelationEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objvQxUserRoleRelationEN.UserId);
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
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
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
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserRoleRelationEN._CurrTabName);
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
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxUserRoleRelationEN._CurrTabName, strCondition);
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
 objSQL = clsvQxUserRoleRelationDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}